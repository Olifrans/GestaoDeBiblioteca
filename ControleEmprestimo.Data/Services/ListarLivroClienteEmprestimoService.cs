using ControleEmprestimo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEmprestimo.Data.Services
{
    public class ListarLivroClienteEmprestimoService
    {
        public RepositoryListarLivroClienteEmprestimo nRepositoryListarLivroClienteEmprestimo { get; set; }
        public ListarLivroClienteEmprestimoService()
        {
            nRepositoryListarLivroClienteEmprestimo = new RepositoryListarLivroClienteEmprestimo();
        }
    }
}
