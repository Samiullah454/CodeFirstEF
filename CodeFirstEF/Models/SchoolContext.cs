using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolEF")
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade>   Grades { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}