using Microsoft.EntityFrameworkCore;

namespace data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
         : base(options)
        {
            
        }
    }
}