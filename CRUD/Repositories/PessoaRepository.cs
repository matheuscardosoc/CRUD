using CRUD.Context;
using CRUD.Models;
using CRUD.Repositories.Interface;

namespace CRUD.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;
        public PessoaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Pessoa> Pessoas => _context.Pessoas;
    }
}
