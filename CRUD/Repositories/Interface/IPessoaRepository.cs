using CRUD.Models;

namespace CRUD.Repositories.Interface
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> Pessoas { get; }

    }
}
