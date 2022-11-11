using EmployeelistAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeelistAPI.Data
{
    public class EmployeeListContext : DbContext
    {
        public EmployeeListContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
