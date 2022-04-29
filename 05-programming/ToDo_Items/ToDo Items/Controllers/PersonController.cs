using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDo_Items.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet(Name ="GetPerson")]
        public string Get()
        {
            return "Hello you";
        }
       
    }
}
