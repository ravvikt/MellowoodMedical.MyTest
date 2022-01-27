using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MellowoodMedical.MyTest.Authorization.Roles;
using MellowoodMedical.MyTest.Authorization.Users;
using MellowoodMedical.MyTest.MultiTenancy;
using MellowoodMedical.MyTest.CMSService;

namespace MellowoodMedical.MyTest.EntityFrameworkCore
{
    public class MyTestDbContext : AbpZeroDbContext<Tenant, Role, User, MyTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyTestDbContext(DbContextOptions<MyTestDbContext> options)
            : base(options)
        {
        }

        public DbSet<Content> CmsContents { get; set; }
    }
}
