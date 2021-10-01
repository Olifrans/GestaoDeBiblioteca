using ControleEmprestimo.Data.Models;
using ControleEmprestimo.Data.Services;
using ControleEmprestimo.Web.Models;
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

        public IActionResult Create()
        {
            EmprestimoViewModel nEmprestimoViewModel = new EmprestimoViewModel();
            List<Livro> nListLivro = _listartimoService.nRepositoryLivro.SelecionarTodos();
            List<Cliente> nListCliente = _listartimoService.nRepositoryCliente.SelecionarTodos();

            nEmprestimoViewModel.nListCliente = nListCliente;
            nEmprestimoViewModel.nListLivro = nListLivro;

            nEmprestimoViewModel.dataEmprestimo = DateTime.Now; //seta data atual
            nEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7); //determina a quantidade de dias

            return View(nEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(EmprestimoViewModel nEmprestimoViewModel)
        {
            LivroClienteEmprestimo nLivroClienteEmprestimo = new LivroClienteEmprestimo();
            nLivroClienteEmprestimo.LcedataEmprestimo = nLivroClienteEmprestimo.LcedataEmprestimo;
            nLivroClienteEmprestimo.LcedataEntrega = nLivroClienteEmprestimo.LcedataEntrega;
            nLivroClienteEmprestimo.LceEntregue = false;
            nLivroClienteEmprestimo.LceidCliente = nLivroClienteEmprestimo.LceidCliente;
            nLivroClienteEmprestimo.LceidLivro = nLivroClienteEmprestimo.LceidLivro;

            if (!ModelState.IsValid)
            {
                return View();
            }
            _listartimoService.nRepositoryLivroClienteEmprestimo.Incluir(nLivroClienteEmprestimo);
            return RedirectToAction("Index");
        }




        //public IActionResult Details(int id)
        //{
        //    Cliente nCliente = nClienteService.nRepositoryCliente.SelecionarPK(id);
        //    return View(nCliente);
        //}

        //[HttpPost]
        //public IActionResult Edit(Cliente model)
        //{
        //    Cliente nCliente = nClienteService.nRepositoryCliente.Alterar(model);
        //    int id = nCliente.Id;
        //    return RedirectToAction("Details", new { id });
        //}

        //public IActionResult Edit(int id)
        //{
        //    Cliente nCliente = nClienteService.nRepositoryCliente.SelecionarPK(id);
        //    return View(nCliente);
        //}

        //public IActionResult Delete(int id)
        //{
        //    nClienteService.nRepositoryCliente.Excluir(id);
        //    return RedirectToAction("Index");
        //}
    }
}
