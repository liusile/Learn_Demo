using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Learn_ABP.Authorization.Users;
using Learn_ABP.Users;

namespace Learn_ABP.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
