using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using abp.graphql-boilerplate.MultiTenancy;

namespace abp.graphql-boilerplate.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
