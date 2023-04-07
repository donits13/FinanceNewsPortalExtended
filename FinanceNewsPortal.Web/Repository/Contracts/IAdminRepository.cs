﻿using FinanceNewsPortal.Web.Models;
using FinanceNewsPortal.Web.ViewModels;

namespace FinanceNewsPortal.Web.Repository.Contracts
{
    public interface IAdminRepository
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<ApplicationUser> GetUserById(Guid userId);
        Task<bool> ToggleUserAccountStatus(Guid userId);
        Task<List<UserWithRoleViewModel>> GetAllUsersExcept(Guid excludedUserId, int pageNumber, int pageSize);
    }
}
