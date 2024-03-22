using API_Dimag.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace API_Dimag.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;

        public ClienteController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("BuscarCliente/{cedulaCliente}")]
        public IActionResult buscarCliente(int celularCliente)
        {
            Cliente cliente = _dbcontext.Clientes.FirstOrDefault(c => c.Telefono == celularCliente);
            if(cliente == null)
            {
                return BadRequest("Cliente no encontrado");
            }

            return Ok(cliente);
        }

        [HttpPost]

        [Route("GuardarCliente")]
        public bool GuardarDetalleVenta([FromBody] Cliente cliente)
        {
            _dbcontext.Clientes.Add(cliente);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
