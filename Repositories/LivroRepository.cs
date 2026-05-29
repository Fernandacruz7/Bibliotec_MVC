
using Bibliotec_MVC.Interfaces;
using Bibliotec_MVC.Models;
using Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec_MVC.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BbDbContext _Context;

        public LivroRepository(BbDbContext context)
        {
            _Context = context;
        }
        public async Task<IEnumerable<Livro>> BuscarLivrosAsync()
        {
            return await _Context.Livro.Include(l => l.livroCategorias).ThenInclude(lc => lc.Categoria).ToListAsync();
        }
    }
}