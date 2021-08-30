using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MVCDemo.Models
{
    public class BatchDbContext : DbContext
    {
        private const string connectionString = "server=admivm\\SQLEXPRESS;database=PracticeDemo;user id=sa;password=pass@123";

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            modelBuilder.UseSqlServer(connectionString);
        }
        public BatchDbContext(DbContextOptions<BatchDbContext> options) : base(options)
        { }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("Admin");

            modelBuilder.Entity<Course>().ToTable("tblCourse");


            modelBuilder.Entity<Course>()
                .Property("Id")
                .HasColumnName("CourseId")
                .IsRequired();

            modelBuilder.Entity<Course>()
            .Property("Name")
            .HasColumnName("CourseName")
            .HasColumnType("varchar(20)")

            .IsRequired();

            modelBuilder.Entity<Course>()
            .Property("Duration")
            .HasColumnName("CourseDuration")
            .IsRequired();

            modelBuilder.Entity<Course>().
                  HasData(new Course
                  {
                      Id = 1,
                      Name = "C#",
                      Duration = 10

                  },
                       new Course
                       {
                           Id = 2,
                           Name = "DOtNet",
                           Duration = 40

                       },
                        new Course

                        {
                            Id = 3,
                            Name = "Java",
                            Duration = 20

                        }
                        );

        }
    }
}
