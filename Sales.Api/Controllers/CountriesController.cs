using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.Api.Controllers;
using Sales.Api.Data;
using Sales.Shared.Entites;

namespace Sales.Api.Controllers
{

    [ApiController]
    [Route("api/countries")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult>PostAsync(Country country) 
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
                
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }




    }//Fin de la clase 
}
