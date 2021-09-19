using ControleEmprestimo.Data.Interfaces;
using ControleEmprestimo.Data.Models;

namespace ControleEmprestimo.Data.Repositories
{
    public class RepositoryListarLivroClienteEmprestimo : RepositoryBase<ListarLivroClienteEmprestimo>, IRepositoryListarLivroClienteEmprestimo
    {
        public RepositoryListarLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
                
        }
    }
}
