using System.Threading.Tasks;
using MellowoodMedical.MyTest.Configuration.Dto;

namespace MellowoodMedical.MyTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
