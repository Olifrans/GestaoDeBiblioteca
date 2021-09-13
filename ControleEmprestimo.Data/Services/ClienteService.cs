using ControleEmprestimo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEmprestimo.Data.Services
{
    public class ClienteService
    {
        public RepositoryCliente nRepositoryCliente { get; set; }

        public ClienteService()
        {
            nRepositoryCliente = new RepositoryCliente();
        }
    }
}
