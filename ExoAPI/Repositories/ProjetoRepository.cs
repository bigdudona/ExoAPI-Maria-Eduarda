using ExoAPI.Contexts;
using ExoAPI.Domain;

namespace ExoAPI.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoAPIContext _ctx;

        public ProjetoRepository(ExoAPIContext ctx) 
        {
            _ctx = ctx;
        }

        public List<Projeto> Listar() 
        {
            return _ctx.Projetos.ToList();

        }

    }
}
