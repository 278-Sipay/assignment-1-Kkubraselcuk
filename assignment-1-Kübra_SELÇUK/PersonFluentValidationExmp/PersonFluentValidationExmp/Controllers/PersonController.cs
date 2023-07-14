using Microsoft.AspNetCore.Mvc;

namespace PersonFluentValidationExmp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController() { }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            return RedirectToAction("Index");
        }

    }
}
