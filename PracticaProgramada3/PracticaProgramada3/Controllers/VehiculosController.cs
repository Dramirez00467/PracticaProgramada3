using Microsoft.AspNetCore.Mvc;
using PracticaProgramada3.BLL.Servicios;

namespace ApiVehiculos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculosController : Controller
    {
        private readonly IVehiculosServicio _vehiculosServicio;

        public VehiculosController(IVehiculosServicio vehiculosServicio)
        {
            _vehiculosServicio = vehiculosServicio;
        }

        [HttpGet(Name = "ObtenerVehiculos")] // ObtenerTodos
        public async Task<IActionResult> ObtenerVehiculos()
        {
            var respuesta = await _vehiculosServicio.ObtenerVehiculosAsync();
            return Ok(respuesta);
        }
    }
}