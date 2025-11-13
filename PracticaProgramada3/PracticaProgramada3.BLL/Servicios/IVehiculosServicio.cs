using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaProgramada3.BLL.Dtos;

namespace PracticaProgramada3.BLL.Servicios
{
    public interface IVehiculosServicio
    {
        Task<CustomResponse<VehiculoDto>> ObtenerVehiculoPorIdAsync(int id);
        Task<CustomResponse<List<VehiculoDto>>> ObtenerVehiculosAsync();
        Task<CustomResponse<VehiculoDto>> AgregarVehiculoAsync(VehiculoDto vehiculoDto);
        Task<CustomResponse<VehiculoDto>> ActualizarVehiculoAsync(VehiculoDto vehiculoDto);
        Task<CustomResponse<VehiculoDto>> EliminarVehiculoAsync(int id);
    }
}