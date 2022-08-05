using CSFriendsCircleBE.Domain;
using Microsoft.EntityFrameworkCore;

namespace CSFriendsCircleBE.Data;

public class ApplicationDbContext : DbContext
{
//ctor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
    public DbSet<User> User { get; set; }
}