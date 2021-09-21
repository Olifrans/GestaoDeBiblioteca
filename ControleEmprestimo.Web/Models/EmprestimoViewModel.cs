using ControleEmprestimo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimo.Web.Models
{
    public class EmprestimoViewModel
    {
        public Livro nLivro { get; set; }
        public Cliente nCliente { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }           
        public List<Cliente> nListCliente { get; set; }
        public List<Livro> nListLivro { get; set; }
    }
}