using Abp.MultiTenancy;
using MellowoodMedical.MyTest.Authorization.Users;

namespace MellowoodMedical.MyTest.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
