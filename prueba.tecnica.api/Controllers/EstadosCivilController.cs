using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba.tecnica.core.dto;
using prueba.tecnica.core.interfaces.services;

namespace prueba.tecnica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosCivilController : ControllerBase
    {
        private readonly IEstadoCivilService _svc;

        public EstadosCivilController(IEstadoCivilService svc)
        {
            _svc = svc;
        }

        [HttpGet]
        [Route("consultar")]
        public IActionResult consultar()
        {
            return Ok(_svc.Consultar());
        }
    }
}
