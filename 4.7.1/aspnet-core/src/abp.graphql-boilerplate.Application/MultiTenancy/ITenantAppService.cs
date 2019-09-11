using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abp.graphql-boilerplate.MultiTenancy.Dto;

namespace abp.graphql-boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

