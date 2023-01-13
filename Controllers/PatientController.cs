using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Pet.Domain.Repository;




namespace Petzey.Pet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        //private IPatient repo = null;

        //public PatientController(IPatient repo)
        //{
        //    this.repo = repo;
        //}
        private IPatient repo = new PatientRepository();

        [HttpPost]
        [EnableQuery]
        //public IActionResult(Patient patient)
        //{

        //}
        public IActionResult AddNewPet(Patient patient)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Infad");
            }
            repo.AddNewPet(patient);
                return (patient);
        }
    }
}
