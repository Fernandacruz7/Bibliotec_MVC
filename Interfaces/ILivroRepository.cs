

using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> BuscarLivrosAsync();
    }
}