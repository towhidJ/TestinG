using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestinG.Models
{
    public partial class StudentDb : DbContext
    {
        public StudentDb()
            : base("name=StudentDb")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
