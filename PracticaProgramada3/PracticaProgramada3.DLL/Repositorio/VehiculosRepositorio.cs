using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticaProgramada3.DLL.Entidades;

namespace PracticaProgramada3.DLL.Repositorio
{
    public class VehiculosRepositorio : IVehiculosRepositorio
    {
        private readonly ApiContext _context;

        public VehiculosRepositorio(ApiContext context)
        {
            _context = context;
        }

        /*****COPY PASTE****/
        public async Task<bool> ActualizarVehiculoAsync(Vehiculo vehiculo)
        {
            var vehiculoActualizar = _context.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id); // recupera el objeto

            vehiculoActualizar.Marca = vehiculo.Marca;   // actualiza la información
            vehiculoActualizar.Modelo = vehiculo.Modelo;
            vehiculoActualizar.Anno = vehiculo.Anno;

            var result = await _context.SaveChangesAsync();     //Aplica los cambios

            return result > 0; //check si funciono
        }

        public async Task<bool> AgregarVehiculoAsync(Vehiculo vehiculo)
        {
            await _context.Vehiculos.AddAsync(vehiculo);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> EliminarVehiculoAsync(int id)
        {
            var vehiculo = _context.Vehiculos.FirstOrDefault(v => v.Id == id);
            _context.Vehiculos.Remove(vehiculo);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<Vehiculo> ObtenerVehiculoPorIdAsync(int id)
        {
            //SP //API // ETC
            var vehiculo = _context.Vehiculos.FirstOrDefault(v => v.Id == id);
            return vehiculo;
        }

        public async Task<List<Vehiculo>> ObtenerVehiculosAsync()
        {
            return await _context.Vehiculos.ToListAsync();
        }
    }
}