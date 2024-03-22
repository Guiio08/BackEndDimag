using API_Dimag.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Dimag.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class PantalonController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;
        public PantalonController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("ListarPantalones")]

        public IActionResult lista()
        {
            List<Pantalones> lista = new List<Pantalones>();
            try
            {
                lista = _dbcontext.Pantalones.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
