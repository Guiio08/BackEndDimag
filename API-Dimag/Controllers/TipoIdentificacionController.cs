using API_Dimag.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Dimag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIdentificacionController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;

        public TipoIdentificacionController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("ListarTipoIdentificacion")]
        public IActionResult lista()
        {
            List<TipoIdentificacion> lista = new List<TipoIdentificacion>();
            try
            {
                lista = _dbcontext.TipoIdentificacions.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
