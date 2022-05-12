using APIminimal.Models;

namespace APIminimal.Service
{
    public class LivroService : ILivroService
    {
        private readonly AppDbContext _context;

        public LivroService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> GetLivros()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Livro>> GetLivrosByNome(string nome)
        { 
            throw new NotImplementedException();
        }

        public async Task<Livro> GetLivro(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateLivro(Livro livro)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        private class Data
        {
            internal class AppDbContext
            {
            }
        }
    }
}
