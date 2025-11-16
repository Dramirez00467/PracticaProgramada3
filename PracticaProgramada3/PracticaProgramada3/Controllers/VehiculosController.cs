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
        [HttpGet("{id}", Name = "ObtenerVehiculoPorId")] // ObtenerPorId
        public async Task<IActionResult> ObtenerVehiculoPorId(int id)
        {
            var respuesta = await _vehiculosServicio.ObtenerVehiculoPorIdAsync(id);
            if (respuesta.Data is null)
            {
                return NotFound("Vehículo no encontrado");
            }
            return Ok(respuesta);
        }
    }
}