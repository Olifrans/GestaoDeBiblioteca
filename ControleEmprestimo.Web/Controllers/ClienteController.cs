using ControleEmprestimo.Data.Models;
using ControleEmprestimo.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimo.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService nClienteService = new ClienteService();

        public IActionResult Index()
        {
            List<Cliente> nListService = nClienteService.nRepositoryCliente.SelecionarTodos();
            return View(nListService);
        }

        public IActionResult Create()        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (ModelState.IsValid)
            {
                //return View();
            }
            nClienteService.nRepositoryCliente.Incluir(model);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            Cliente nCliente = nClienteService.nRepositoryCliente.SelecionarPK(id);
            return View(nCliente);
        }


        public IActionResult Edit(int id)
        {
            Cliente nCliente = nClienteService.nRepositoryCliente.SelecionarPK(id);
            return View(nCliente);
        }

        
    }
}
