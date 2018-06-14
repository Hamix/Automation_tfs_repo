using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using Security.Data.Entities;

namespace Security.Data.Services.Infrastructure
{
    public interface IMembershipService : IRepositoryService
    {
        MembershipContext ValidateUser(string username, string password);
        User CreateUser(string username, string email, string password, string fullname, string phoneNumber,int? predicate);
        User GetUser(int userId);
        List<Role> GetUserRoles(string username);
    }

}
