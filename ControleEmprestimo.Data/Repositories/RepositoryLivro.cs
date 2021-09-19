using ControleEmprestimo.Data.Interfaces;
using ControleEmprestimo.Data.Models;

namespace ControleEmprestimo.Data.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {
                
        }
    }
}