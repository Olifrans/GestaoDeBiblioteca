using ControleEmprestimo.Data.Repositories;

namespace ControleEmprestimo.Data.Services
{
    public class LivroService
    {
        public RepositoryLivro nRepositoryLivro { get; set; }

        public LivroService()
        {
            nRepositoryLivro = new RepositoryLivro();
        }
    }
}
