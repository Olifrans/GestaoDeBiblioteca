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

            return View(nEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(ListarLivroClienteEmprestimo model)
        {
            if (ModelState.IsValid)
            {
                //return View();
            }
            _listartimoService.nRepositoryListarLivroClienteEmprestimo.Incluir(model);
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
