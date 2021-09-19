using ControleEmprestimo.Data.Interfaces;
using ControleEmprestimo.Data.Models;

namespace ControleEmprestimo.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {
                
        }
    }
}
