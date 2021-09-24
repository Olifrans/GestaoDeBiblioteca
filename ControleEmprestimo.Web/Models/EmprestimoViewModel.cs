using ControleEmprestimo.Data.Models;
using System;
using System.Collections.Generic;

namespace ControleEmprestimo.Web.Models
{
    public class EmprestimoViewModel
    {
        public Livro nLivro { get; set; }
        public Cliente nCliente { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }

        public int idCliente { get; set; }

        public int idLivro { get; set; }

        public List<Cliente> nListCliente { get; set; }
        public List<Livro> nListLivro { get; set; }
    }
}