using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.tecnica.core.dto
{
    public class requestItem
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public decimal? IdTipoDoc { get; set; }
        public string? nroDocumento { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? Valor { get; set; }
        public decimal? IdEstadoCivil { get; set; }
    }
}
