using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemoENG.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController: ControllerBase
    {
        [HttpPost]
        public ActionResult Post(Person person)
        {
            return Ok();
        }
    }
}
