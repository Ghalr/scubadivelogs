using System.Linq;
using scubadivelogs.EntityFramework;
using scubadivelogs.MultiTenancy;

namespace scubadivelogs.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly scubadivelogsDbContext _context;

        public DefaultTenantCreator(scubadivelogsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
