using ControleEmprestimo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
