using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Data;
using RelacionesEF_DataAnotations.Models.OneToOne;

namespace RelacionesEF_DataAnotations.Repositorios.OneToOne
{
    public class RepositorioOneToOne
    {
        private readonly AppDbContext _appDbContext;
        public RepositorioOneToOne(AppDbContext context)
        {
            _appDbContext = context;            
        }

        public async Task<List<CarCompany>> GetCarCompanies()=>
            await _appDbContext.CarCompanies.ToListAsync();
        public async Task AddCarCompany(CarCompany company)
        {
            _appDbContext.CarCompanies.Add(company);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task AddCarModel(CarModel model)
        {
            _appDbContext.CarModels.Add(model);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<CarModel>> GetCarModels() =>
            await _appDbContext.CarModels.ToListAsync();
    }
}
