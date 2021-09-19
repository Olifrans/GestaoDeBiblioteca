using ControleEmprestimo.Data.Models;
using ControleEmprestimo.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimo.Web.Controllers
{
    public class EmprestimoController : Controller
    {
        private ListarLivroClienteEmprestimoService _listartimoService = new ListarLivroClienteEmprestimoService();
        public IActionResult Index()
        {
            List<ListarLivroClienteEmprestimo> nListService = _listartimoService.nRepositoryListarLivroClienteEmprestimo.SelecionarTodos();
            return View(nListService);
        }
    }
}
