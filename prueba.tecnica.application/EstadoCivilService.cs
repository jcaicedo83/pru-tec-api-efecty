using prueba.tecnica.core.dto;
using prueba.tecnica.core.interfaces.repository;
using prueba.tecnica.core.interfaces.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.tecnica.application
{
    public class EstadoCivilService:IEstadoCivilService
    {
        private readonly IEstadoCivilRepository _repo;

        public EstadoCivilService(IEstadoCivilRepository repo)
        {
            _repo = repo;
        }

        public ResponseItem Consultar()
        {
            return _repo.Consultar();
        }
    }
}
