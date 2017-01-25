using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using scubadivelogs.MultiTenancy.Dto;

namespace scubadivelogs.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
