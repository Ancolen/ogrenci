using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_Tool.Models;


namespace Student_Management_Tool.Data
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseConfig.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Lessons)
                .WithOne(l => l.Student)
                .HasForeignKey(l => l.StudentId);
        }
    } 
}
