using System.Threading.Tasks;
using Abp.Application.Services;
using abp.graphql-boilerplate.Sessions.Dto;

namespace abp.graphql-boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
