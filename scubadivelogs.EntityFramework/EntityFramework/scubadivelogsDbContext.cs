using System.Data.Common;
using Abp.Zero.EntityFramework;
using scubadivelogs.Authorization.Roles;
using scubadivelogs.MultiTenancy;
using scubadivelogs.Users;

namespace scubadivelogs.EntityFramework
{
    public class scubadivelogsDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public scubadivelogsDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in scubadivelogsDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of scubadivelogsDbContext since ABP automatically handles it.
         */
        public scubadivelogsDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public scubadivelogsDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
