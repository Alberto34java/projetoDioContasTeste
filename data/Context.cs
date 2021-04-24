using Microsoft.EntityFrameworkCore;
using Models;

namespace data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
         : base(options)
        {
            
        }

        public DbSet<BancoSA> BancoSAs{ get; set;}
    }
}