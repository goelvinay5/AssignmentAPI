using Microsoft.EntityFrameworkCore;
using AssignmentAPI.Models;

namespace AssignmentAPI.DataContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
