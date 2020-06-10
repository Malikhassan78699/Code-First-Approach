using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication15.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication15.DAL
{
    public class SchoolContext:DbContext
    {

        public SchoolContext():base("SchoolContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }


}
