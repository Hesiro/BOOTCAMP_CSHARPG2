using Microsoft.EntityFrameworkCore;
using Relation_FluentApi.Models.ManyToMany;
using Relation_FluentApi.Models.OneToMany;
using Relation_FluentApi.Models.OneToOne;

namespace Relation_FluentApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            /*One-To-One*/
            modelBuilder.Entity<CarCompany>()
                .HasOne(x => x.CarModel)
                .WithOne(p => p.CarCompany)
                .HasForeignKey<CarModel>(t => t.CarCompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.EmployeeAddress)
                .WithOne(p => p.Employee)
                .HasForeignKey<EmployeeAddress>(t => t.EmployeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Doctor>()
                .HasMany(x => x.Pattients)
                .WithOne(p => p.Doctor)
                .HasForeignKey(t => t.DoctorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<StudentMateria>()
                .HasKey(x => new { x.StudentId, x.MateriaId });

            modelBuilder.Entity<StudentMateria>()
                .HasOne(x => x.Student)
                .WithMany(p => p.StudentsMaterias)
                .HasForeignKey(t => t.StudentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentMateria>()
                .HasOne(x => x.Materia)
                .WithMany(p => p.StudentsMaterias)
                .HasForeignKey(t => t.MateriaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<PersonBusiness>()
                .HasKey(x => new { x.PersonId, x.BusinessId });

            modelBuilder.Entity<PersonBusiness>()
                .HasOne(x => x.Person)
                .WithMany(p => p.PersonsBusiness)
                .HasForeignKey(t => t.PersonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonBusiness>()
                .HasOne(x => x.Business)
                .WithMany(p => p.PersonsBusiness)
                .HasForeignKey(t => t.BusinessId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
