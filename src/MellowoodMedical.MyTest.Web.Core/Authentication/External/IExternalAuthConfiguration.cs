using System.Collections.Generic;

namespace MellowoodMedical.MyTest.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
