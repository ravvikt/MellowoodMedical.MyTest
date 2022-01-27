using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MellowoodMedical.MyTest.MultiTenancy.Dto;

namespace MellowoodMedical.MyTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

