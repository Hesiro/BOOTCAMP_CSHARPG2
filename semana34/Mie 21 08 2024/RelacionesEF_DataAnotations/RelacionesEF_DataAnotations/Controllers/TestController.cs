using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelacionesEF_DataAnotations.Models.OneToMany;
using RelacionesEF_DataAnotations.Models.OneToOne;
using RelacionesEF_DataAnotations.Repositorios.OneToMany;
using RelacionesEF_DataAnotations.Repositorios.OneToOne;

namespace RelacionesEF_DataAnotations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly RepositorioOneToOne _repositorioOneToOne;
        private readonly RepositorioOneToMany _repositoriosOneToMany;
        public TestController(RepositorioOneToOne repositorioOneToOne,
            RepositorioOneToMany repositorioOneToMany)
        {
            _repositorioOneToOne = repositorioOneToOne;
            _repositoriosOneToMany = repositorioOneToMany;
        }

        [HttpPost("CarCompany")]
        public async Task<IActionResult> AddCarCompany(CarCompany carCompany)
        {
            await _repositorioOneToOne.AddCarCompany(carCompany);
            return Ok("Company saved");
        }
        [HttpGet("CarCompany")]
        public async Task<IActionResult> GetCarCompanies()
        {
            var companies = await _repositorioOneToOne.GetCarCompanies();
            return Ok(companies);
        }

        [HttpPost("CarModel")]
        public async Task<IActionResult> AddCarModel(CarModel carModel)
        {
            await _repositorioOneToOne.AddCarModel(carModel);
            return Ok("Model saved");
        }        

        [HttpGet("CarModel")]
        public async Task<IActionResult> GetCarModels()
        {
            var models = await _repositorioOneToOne.GetCarModels();
            return Ok(models);
        }
        [HttpPost("Doctor")]
        public async Task<IActionResult> AddDoctor(Doctor doctor)
        {
            await _repositoriosOneToMany.AddDoctor(doctor);
            return Ok("Doctor saved");
        }
        [HttpGet("Doctor")]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _repositoriosOneToMany.GerDoctors();
            return Ok(doctors);
        }
        [HttpPost("Patient")]
        public async Task<IActionResult> AddPatient(Patient patient)
        {
            await _repositoriosOneToMany.AddPatient(patient);
            return Ok("Patient saved");
        }
        [HttpGet("Patient")]
        public async Task<IActionResult> GetPatients()
        {
            var patients = await _repositoriosOneToMany.GetPatients();
            return Ok(patients);
        }
    }
}
