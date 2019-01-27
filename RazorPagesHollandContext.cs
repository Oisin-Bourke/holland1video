using Microsoft.EntityFrameworkCore;

namespace RazorPagesHolland.Models

{
    public class RazorPagesHollandContext : DbContext
    {
        public RazorPagesHollandContext(DbContextOptions<RazorPagesHollandContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesHolland.Models.Holland> Holland { get; set; } //creates the 'enitity set' or table 
    }
}
