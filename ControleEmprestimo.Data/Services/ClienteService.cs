using ControleEmprestimo.Data.Repositories;

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
