using ControleEmprestimo.Data.Interfaces;
using ControleEmprestimo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEmprestimo.Data.Repositories
{
    public class RepositoryListaLivroClientesEmprestimo : RepositoryBase
        <ListaLivroClientesEmprestimo>, IRepositoryListaLivroClientesEmprestimo
    {
        public RepositoryListaLivroClientesEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
                
        }
    }
}
