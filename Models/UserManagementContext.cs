using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class UserManagementContext : DbContext
    {
        public UserManagementContext(DbContextOptions<UserManagementContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
