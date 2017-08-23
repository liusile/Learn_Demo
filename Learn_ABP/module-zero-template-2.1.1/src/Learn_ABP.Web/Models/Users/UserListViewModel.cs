using System.Collections.Generic;
using Learn_ABP.Roles.Dto;
using Learn_ABP.Users.Dto;

namespace Learn_ABP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}