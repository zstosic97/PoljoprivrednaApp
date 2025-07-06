using BACKEND.Data;
using BACKEND.Models;
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
        [HttpPost]
        public IActionResult Post(Prodavatelj prodavatelj)
        {
            try
            {
                _context.Prodavatelji.Add(prodavatelj);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, prodavatelj);
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }

        }

        [HttpPut("sifra:int")]
        public IActionResult Put(int sifra, Prodavatelj prodavatelj)
        {
            if (sifra < 1)
            {
                return BadRequest(new { poruka = "Šifra mora biti veća od 0" });
            }

            try
            {
                Prodavatelj s = _context.Prodavatelji.Find(sifra);

                if (s == null)
                {
                    return NotFound();

                }

                // za sada ručno, klasnije automatika
                s.Naziv = prodavatelj.Naziv;
                s.AdresaSjedista = prodavatelj.AdresaSjedista;
                s.Email = prodavatelj.Email;

                _context.Prodavatelji.Update(s);
                _context.SaveChanges();
                return Ok(s);






            }
            catch (Exception e)
            {
                return BadRequest(e);

            }

        }

        [HttpDelete("sifra:int")]
        public IActionResult Delete (int sifra)
        {
            if (sifra < 1)
            {
                return BadRequest(new { poruka = "Šifra mora biti veća od 0" });
            }

            try
            {
                Prodavatelj s = _context.Prodavatelji.Find(sifra);

                if (s == null)
                {
                    return NotFound();

                }

                _context.Prodavatelji.Remove(s);
                _context.SaveChanges();
                return NoContent();

            }
            catch (Exception e)
            {
                return BadRequest(e);

            }

        }

       
    }
}
