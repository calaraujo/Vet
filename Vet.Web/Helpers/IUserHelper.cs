﻿using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Vet.Web.Data.Entities;
using Vet.Web.Models;

namespace Vet.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<bool> DeleteUserAsync(string email);

        Task<IdentityResult> UpdateUserAsync(User user);
        Task<SignInResult> ValidatePasswordAsync(User user, string password);

    }
}
