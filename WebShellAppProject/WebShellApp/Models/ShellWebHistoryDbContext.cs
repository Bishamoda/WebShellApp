using Microsoft.EntityFrameworkCore;

namespace WebShellApp.Models
{
    public class ShellWebHistoryDbContext : DbContext
    {
        const string CONNECTION = "Server=DESKTOP-50OP8K5;Database=ShellWebHistory;Trusted_Connection=True;";

        public DbSet<CommandHistory> CommandHistory { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION);
        }

    }
}
