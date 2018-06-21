using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Automation.Core.Web.Infrastructure.Extensions;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Http;
using Security.Data.Services.Infrastructure;

namespace Automation.Core.Web.Infrastructure
{
    public class AuthenticationHandler : DelegatingHandler
    {
        private readonly IMembershipService _membershipService;
        IEnumerable<string> _authHeaderValues = null;

        public AuthenticationHandler(IStorageService storageService)
        {
            _membershipService = storageService.GetRepositoryService<IMembershipService>();
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            //return base.SendAsync(request, cancellationToken);
            try
            {
                request.Headers.TryGetValues("Authorization", out _authHeaderValues);
                if (_authHeaderValues == null)
                    return base.SendAsync(request, cancellationToken); // cross fingers

                var tokens = _authHeaderValues.FirstOrDefault();

                if (tokens != null)
                {
                    tokens = tokens.Replace("Basic", "").Trim();
                    if (!string.IsNullOrEmpty(tokens))
                    {
                        byte[] data = Convert.FromBase64String(tokens);
                        string decodedString = Encoding.UTF8.GetString(data);
                        string[] tokensValues = decodedString.Split(':');


                        var membershipCtx = _membershipService.ValidateUser(tokensValues[0], tokensValues[1]);
                        if (membershipCtx.User != null)
                        {
                            IPrincipal principal = membershipCtx.Principal;
                            Thread.CurrentPrincipal = principal;

                            //HttpContext.Current.User = principal;
                        }
                        else // Unauthorized access - wrong crededentials
                        {
                            var response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                            var tsc = new TaskCompletionSource<HttpResponseMessage>();
                            tsc.SetResult(response);
                            return tsc.Task;
                        }
                    }
                    else
                    {
                        var response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                        var tsc = new TaskCompletionSource<HttpResponseMessage>();
                        tsc.SetResult(response);
                        return tsc.Task;
                    }
                }

                return base.SendAsync(request, cancellationToken);
            }
            catch
            {
                var response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                var tsc = new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(response);
                return tsc.Task;
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}
