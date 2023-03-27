using System;
using System.Collections.Generic;

namespace prueba.tecnica.infraestructure.Models
{
    public partial class TblEstadoCivil
    {
        public decimal? IdEstadoCivil { get; set; }
        public string? CodEstadoCivil { get; set; }
        public string? DescEstadoCivil { get; set; }
        public decimal? Activo { get; set; }
    }
}
