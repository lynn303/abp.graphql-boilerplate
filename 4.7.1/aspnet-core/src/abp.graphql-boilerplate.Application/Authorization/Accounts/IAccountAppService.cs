using System.Threading.Tasks;
using Abp.Application.Services;
using abp.graphql-boilerplate.Authorization.Accounts.Dto;

namespace abp.graphql-boilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
