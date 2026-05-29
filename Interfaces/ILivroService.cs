
using Bibliotec_MVC.Models;

namespace Bibliotec_MVC.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> BuscarLivrosComCat();
    }
}