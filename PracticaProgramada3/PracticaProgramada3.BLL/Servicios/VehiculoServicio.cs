using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PracticaProgramada3.BLL.Dtos;
using PracticaProgramada3.DLL.Entidades;
using PracticaProgramada3.DLL.Repositorio;

namespace PracticaProgramada3.BLL.Servicios
{
    public class VehiculoServicio : IVehiculosServicio
    {
        //Inyección de dependencias
        private readonly IVehiculosRepositorio _vehiculosRepositorio;
        private readonly IMapper _mapper;

        public VehiculoServicio(IVehiculosRepositorio vehiculosRepositorio, IMapper mapper)
        {
            _vehiculosRepositorio = vehiculosRepositorio;
            _mapper = mapper;
        }

        public async Task<CustomResponse<VehiculoDto>> AgregarVehiculoAsync(VehiculoDto vehiculoDto)
        {
            var respuesta = new CustomResponse<VehiculoDto>();

            if (!await _vehiculosRepositorio.AgregarVehiculoAsync(_mapper.Map<Vehiculo>(vehiculoDto)))
            {
                respuesta.EsError = true;
                respuesta.Mensaje = "No fue posible crear el registro";
                return respuesta;
            }
            return respuesta;
        }

        public async Task<CustomResponse<VehiculoDto>> ActualizarVehiculoAsync(VehiculoDto vehiculoDto)
        {
            var respuesta = new CustomResponse<VehiculoDto>();
            var vehiculo = _mapper.Map<Vehiculo>(vehiculoDto);
            if (!await _vehiculosRepositorio.ActualizarVehiculoAsync(vehiculo))
            {
                respuesta.EsError = true;
                respuesta.Mensaje = "No fue posible actualizar el registro";
                return respuesta;
            }
            return respuesta;
        }

        public async Task<CustomResponse<VehiculoDto>> EliminarVehiculoAsync(int id)
        {
            var respuesta = new CustomResponse<VehiculoDto>();
            if (!await _vehiculosRepositorio.EliminarVehiculoAsync(id))
            {
                respuesta.EsError = true;
                respuesta.Mensaje = "No fue posible eliminar el registro";
                return respuesta;
            }
            return respuesta;
        }

        public async Task<CustomResponse<VehiculoDto>> ObtenerVehiculoPorIdAsync(int id)
        {
            var respuesta = new CustomResponse<VehiculoDto>();
            var vehiculo = await _vehiculosRepositorio.ObtenerVehiculoPorIdAsync(id);
            respuesta.Data = _mapper.Map<VehiculoDto>(vehiculo);
            return respuesta;
        }

        public async Task<CustomResponse<List<VehiculoDto>>> ObtenerVehiculosAsync()
        {
            var respuesta = new CustomResponse<List<VehiculoDto>>();
            var vehiculos = await _vehiculosRepositorio.ObtenerVehiculosAsync();
            var vehiculosDto = _mapper.Map<List<VehiculoDto>>(vehiculos);
            respuesta.Data = vehiculosDto;
            return respuesta;
        }
    }
}