using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using scubadivelogs.EntityFramework;

namespace scubadivelogs
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(scubadivelogsCoreModule))]
    public class scubadivelogsDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<scubadivelogsDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
