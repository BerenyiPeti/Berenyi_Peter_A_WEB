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
                var list = (from k in _context.kategoria
                            join t in _context.teszt
                            on k.id equals t.kategoriaId
                            select new { t.id, t.kerdes, t.v1, t.v2, t.v3, t.v4, t.helyes, t.kategoriaId, k.kategorianev }).ToList();

            //_context.teszt.ToList();

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
