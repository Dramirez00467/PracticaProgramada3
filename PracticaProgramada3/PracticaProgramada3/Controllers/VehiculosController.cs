using Microsoft.AspNetCore.Mvc;
using PracticaProgramada3.BLL.Dtos;
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

    [HttpPost(Name = "CrearVehiculo")] // Crear
        public async Task<IActionResult> CrearVehiculo(VehiculoDto vehiculo)
        {
            var respuesta = await _vehiculosServicio.AgregarVehiculoAsync(vehiculo);
            if (respuesta.EsError)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta);
        }

        [HttpPut(Name = "ActualizarVehiculo")] // Actualizar
        public async Task<IActionResult> ActualizarVehiculo(VehiculoDto vehiculo)
        {
            var respuesta = await _vehiculosServicio.ActualizarVehiculoAsync(vehiculo);
            return Ok(respuesta);
        }

        [HttpDelete("{id}", Name = "EliminarVehiculo")] // Eliminar
        public async Task<IActionResult> EliminarVehiculo(int id)
        {
            var respuesta = await _vehiculosServicio.EliminarVehiculoAsync(id);
            return Ok(respuesta);
        }
    } 
}