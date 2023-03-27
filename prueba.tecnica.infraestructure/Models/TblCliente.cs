using System;
using System.Collections.Generic;

namespace prueba.tecnica.infraestructure.Models
{
    public partial class TblCliente
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? nroDocumento { get; set; }
        public decimal? IdTipoDoc { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? Valor { get; set; }
        public decimal? IdEstadoCivil { get; set; }
    }
}
