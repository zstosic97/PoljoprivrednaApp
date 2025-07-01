using BACKEND.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{ 
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProdavateljController : ControllerBase
       
        
    {
        // koristimo dependency injection

        // 1. definiramo privatno svojstvo
        private readonly EdunovaContext _context;

        // 2. u nosktruktoru postavljamo vrijednost

        public ProdavateljController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Prodavatelji);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }


        }
       
    }
}
