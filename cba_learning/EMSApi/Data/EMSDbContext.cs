using EMSApi.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMSApi.Data
{
    public class EMSDbContext : IdentityDbContext<ApplicationUser>
    {
        // conection string 

        // server , credentials and how many connections in parralel

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EMSDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        // tables code first 
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}
