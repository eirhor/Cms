using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cms.Core.Identity.Contexts
{
    public class CmsIdentityContext<T> : IdentityDbContext<T> where T: IdentityUser
    {
        public CmsIdentityContext(DbContextOptions options): base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}