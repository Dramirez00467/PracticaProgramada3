using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramada3.DLL.Entidades
{
    public partial class Vehiculo
    {
        public int Id { get; set; }

        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public int? Anno { get; set; }
    }
}
