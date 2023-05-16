using Assignment2Web.Shared;
using Microsoft.EntityFrameworkCore;

namespace Assignment2Web.Server.DataContext
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }
        public DbSet<portfolioDetails> portfolioDetails { get; set; }

    }
}
