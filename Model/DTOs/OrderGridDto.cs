using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adarec_ui.Model.DTOs
{
    public class OrderGridDto
    {
        public int? IdOrden { get; set; }
        public string Descripcion { get; set; }
        public string FechaProgramada { get; set; }
        public string Estado { get; set; }
        public string EstadoDescripcion { get; set; }
        public string Cliente { get; set; }
        public string CedulaCliente { get; set; }
        public string Tecnico { get; set; }
        public string TecnicoNombre { get; set; }
    }
}
