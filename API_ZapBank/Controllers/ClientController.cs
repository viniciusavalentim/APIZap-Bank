using API_ZapBank.Models;
using API_ZapBank.Service.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ZapBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ServiceResponse<List<ClientModel>>> GetCLient() //ActionResult - é igual ao ok ou badrequest
        {
            return Ok();
        }
    }
}
