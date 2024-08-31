using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Models.ManyToMany;
using RelacionesEF_DataAnotations.Models.OneToMany;
using RelacionesEF_DataAnotations.Models.OneToOne;

namespace RelacionesEF_DataAnotations.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        /*One To One*/
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarCompany> CarCompanies { get; set; }

        /*One To Many*/
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        /*Many To Many*/
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
