using Abp.AutoMapper;
using Learn_ABP.Sessions.Dto;

namespace Learn_ABP.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}