using ControleEmprestimo.Data.Interfaces;
using ControleEmprestimo.Data.Models;

namespace ControleEmprestimo.Data.Repositories
{
    public class RepositoryLivroClienteEmprestimo : RepositoryBase<LivroClienteEmprestimo>, IRepositoryLivroClienteEmprestimo
    {
        public RepositoryLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
                
        }
    }
}
