using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PracticaProgramada3.BLL.Dtos;
using PracticaProgramada3.DLL.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaProgramada3.BLL.Mapeos
{
    public class MapeoClases : Profile
    {
        public MapeoClases()
        {
            CreateMap<Vehiculo, VehiculoDto>();
            CreateMap<VehiculoDto, Vehiculo>();
        }
    }
}