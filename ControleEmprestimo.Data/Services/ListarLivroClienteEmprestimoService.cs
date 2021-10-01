using ControleEmprestimo.Data.Repositories;

namespace ControleEmprestimo.Data.Services
{
    public class ListarLivroClienteEmprestimoService
    {
        public RepositoryListarLivroClienteEmprestimo nRepositoryListarLivroClienteEmprestimo { get; set; }

        public RepositoryCliente nRepositoryCliente { get; set; }
        public RepositoryLivro nRepositoryLivro { get; set; }

        public RepositoryLivroClienteEmprestimo nRepositoryLivroClienteEmprestimo { get; set; }


        public ListarLivroClienteEmprestimoService()
        {
            nRepositoryListarLivroClienteEmprestimo = new RepositoryListarLivroClienteEmprestimo();
            nRepositoryCliente = new RepositoryCliente();
            nRepositoryLivro = new RepositoryLivro();
            nRepositoryLivroClienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
