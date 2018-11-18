using Microsoft.EntityFrameworkCore;

namespace Cms.Core.Data.Contexts
{
    public class CmsContext: DbContext
    {
        public CmsContext(DbContextOptions options): base(options) {}
    }
}