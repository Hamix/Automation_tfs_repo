using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Security.Api.Version1.Controllers;
using Xunit;

namespace Security.UnitTests
{
    public class ApiVersion1Test
    {
        private UserController controller;

        public ApiVersion1Test()
        {
            //controller = new UserController();

        }

        [Fact]
        public async Task IndexTest_ReturnsViewWithArticlesList()
        {
        }
    }
}
