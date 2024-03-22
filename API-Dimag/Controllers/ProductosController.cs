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
    public class ProductosController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;

        public ProductosController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("ListarProductos")]

        public IActionResult lista()
        {
            List<TipoProducto> lista = new List<TipoProducto>();
            try
            {
                lista = _dbcontext.TipoProductos.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
