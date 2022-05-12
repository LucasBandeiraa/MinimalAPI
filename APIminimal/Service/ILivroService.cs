using APIminimal.Models;

namespace APIminimal.Service
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> GetLivros();

        Task<Livro> GetLivro(int id);

        Task<IEnumerable<Livro>> GetLivrosByNome(string nome);

        Task CreateLivro(Livro livro);
        Task UpdateLivro(Livro livro);
        Task DeleteLivro(Livro livro);
    }
}
