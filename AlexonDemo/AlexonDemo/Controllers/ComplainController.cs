using AlexonDemo.Interfaces;
using AlexonDemo.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlexonDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : Controller
    {

        private IComplain _complain;

        public ComplainController(IComplain complain)
        {
            _complain = complain;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("GetComplains")]
        public ActionResult GetComplains()
        {
            List<Complain> complains = _complain.GetAllComplains();

            return Ok(complains);
        }
    }
}
