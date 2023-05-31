using Backend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("kategoria")]
    [ApiController]
    public class KategoriaController : ControllerBase
    {
        TermeszetVedelemContext _context;

        public KategoriaController(TermeszetVedelemContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult List()
        {
            try
            {
                var list =
            _context.kategoria.ToList();

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
