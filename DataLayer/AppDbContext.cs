using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<SubjectModel> SubjectModel { get; set; }
        public DbSet<MarksModel> MarksModel { get; set; }
    }
}
