using API_Dimag.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Dimag.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;

        public GeneroController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("ListarGenero")]

        public IActionResult lista()
        {
            List<Genero> lista = new List<Genero>();
            try
            {
                lista = _dbcontext.Generos.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
