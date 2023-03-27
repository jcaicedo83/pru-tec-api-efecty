using prueba.tecnica.core.dto;
using prueba.tecnica.core.interfaces.repository;
using prueba.tecnica.core.interfaces.services;

namespace prueba.tecnica.application
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _repo;

        public ClientesService(IClientesRepository repo)
        {
            _repo = repo;
        }

        public ResponseItem Consultar(requestItem item)
        {
            return _repo.Consultar(item);
        }

        public ResponseItem Insertar(requestItem item)
        {
            return _repo.Insertar(item);
        }

        public ResponseItem Actualizar(requestItem item)
        {
            return _repo.Actualizar(item);
        }

        public ResponseItem Eliminar(requestItem item)
        {
            return _repo.Eliminar(item);
        }
    }
}