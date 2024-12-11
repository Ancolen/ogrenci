using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Tool.Data
{
    
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<StudentManagementContext>
    {
        public StudentManagementContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentManagementContext>();
            optionsBuilder.UseSqlServer(DatabaseConfig.ConnectionString);

            return new StudentManagementContext(optionsBuilder.Options);
        }
    }
}
