using ExoAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoAPI.Contexts
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        public ProjetoController(ProjetoRepository projetoRepository)
            {
                _projetoRepository = projetoRepository;
            }

        [HttpGet]
        public IActionResult Get()  
        {
            return Ok(_projetoRepository.Listar());
        }
    }
}
