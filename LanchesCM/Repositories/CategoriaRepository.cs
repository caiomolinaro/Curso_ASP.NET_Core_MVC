using LanchesCM.Context;
using LanchesCM.Models;
using LanchesCM.Repositories.Interfaces;

namespace LanchesCM.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
