using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext") // this is the name of the connection string which will be used in Web.config file
        {

        }
        public DbSet <Student> Students { get; set; } //Db set represent a database entity set and allow you to perform CRUD Operations
        public DbSet <Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        //OnModelCreating is used
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // this method prevents table names from being pluralized
        }
    }
}