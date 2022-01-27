using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MellowoodMedical.MyTest.Configuration;

namespace MellowoodMedical.MyTest.Web.Host.Startup
{
    [DependsOn(
       typeof(MyTestWebCoreModule))]
    public class MyTestWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyTestWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTestWebHostModule).GetAssembly());
        }
    }
}
