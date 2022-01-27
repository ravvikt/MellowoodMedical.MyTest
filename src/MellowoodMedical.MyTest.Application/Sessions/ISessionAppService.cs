using System.Threading.Tasks;
using Abp.Application.Services;
using MellowoodMedical.MyTest.Sessions.Dto;

namespace MellowoodMedical.MyTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
