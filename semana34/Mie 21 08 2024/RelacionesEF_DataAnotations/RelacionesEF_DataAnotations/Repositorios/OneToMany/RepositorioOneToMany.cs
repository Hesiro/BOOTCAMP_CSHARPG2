using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Data;
using RelacionesEF_DataAnotations.Models.OneToMany;

namespace RelacionesEF_DataAnotations.Repositorios.OneToMany
{
    public class RepositorioOneToMany
    {
        private readonly AppDbContext _appDbContext;
        public RepositorioOneToMany(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //patient
        public async Task AddPatient(Patient patient)
        {
            _appDbContext.Patients.Add(patient);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Patient>> GetPatients()=>
            await(_appDbContext.Patients.ToListAsync());

        //doctor
        public async Task AddDoctor(Doctor doctor)
        {
            _appDbContext.Doctors.Add(doctor);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Doctor>> GerDoctors() =>
            await(_appDbContext.Doctors.ToListAsync());
    }
}
