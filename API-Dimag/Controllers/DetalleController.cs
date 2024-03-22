using API_Dimag.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Dimag.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        public readonly DBDimagContext _dbcontext;

        public DetalleController(DBDimagContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        [HttpPost]

        [Route("GuardarDetalleVenta")]
        public bool GuardarDetalleVenta([FromBody] DetalleVenta detalleVenta)
        {
            _dbcontext.DetallesVenta.Add(detalleVenta);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
