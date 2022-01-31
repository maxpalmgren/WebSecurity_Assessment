using Microsoft.EntityFrameworkCore;
using WebSecurity_Assessment.Models;

namespace WebSecurity_Assessment
{
    public class SqlContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }
    }
}
