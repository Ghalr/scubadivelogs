using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using scubadivelogs.EntityFramework;

namespace scubadivelogs.Migrator
{
    [DependsOn(typeof(scubadivelogsDataModule))]
    public class scubadivelogsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<scubadivelogsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}