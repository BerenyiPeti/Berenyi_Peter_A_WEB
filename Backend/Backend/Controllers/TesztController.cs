using Backend.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("tesztek")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        TermeszetVedelemContext _context;

        public TesztController(TermeszetVedelemContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult List()
        {
            try
            {
                var list =
            _context.teszt.ToList();

                if (list.Count() == 0)
                {
                    return NotFound("table not found.");
                }
                return Ok(list);

            }
            catch (Exception e)
            {
                return StatusCode(404, e);
            }
        }
    }
}
