using API_Dimag.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Dimag.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class BlusaController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;
        public BlusaController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("ListarBlusas")]
        public IActionResult lista()
        {
            List<Blusas> lista = new List<Blusas>();
            try
            {
                lista = _dbcontext.Blusas.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
