using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Dimag.Models;
using Microsoft.AspNetCore.Cors;

namespace API_Dimag.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class UniformesController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;

        public UniformesController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("ListarUniformes")]

        public IActionResult lista()
        {
            List<Uniforme> lista = new List<Uniforme>();

            try
            {
                lista = _dbcontext.Uniformes.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
