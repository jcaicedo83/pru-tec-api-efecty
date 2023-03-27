using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using prueba.tecnica.core.dto;
using prueba.tecnica.core.interfaces.repository;
using prueba.tecnica.infraestructure.Models;

namespace prueba.tecnica.infraestructure
{
    public class EstadoCivilRepository : IEstadoCivilRepository
    {
        private readonly IConfiguration _config;
        private string _dbName;
        public EstadoCivilRepository(IConfiguration config)
        {
            _config = config;
            _dbName = _config.GetConnectionString("sqlDb");
        }

        public ResponseItem Consultar()
        {
            ResponseItem response = new ResponseItem { ok = false, mensaje = string.Empty, resultado = null };
            try
            {
                using (PtDboContext repo = new PtDboContext(_dbName))
                {
                    var result = (from item in repo.TblEstadoCivils
                                  where item.Activo == 1
                                  select item).ToList();

                    repo.Database.CloseConnection();

                    response.resultado = result;
                    response.ok = true;
                }
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
            }

            return response;
            
        }
    }


}
