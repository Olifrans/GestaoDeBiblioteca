using ControleEmprestimo.Data.Models;
using ControleEmprestimo.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimo.Web.Controllers
{
    public class LivroController : Controller
    {
        private LivroService nLivroService = new LivroService();        
        public IActionResult Index()
        {
            List<Livro> nListService = nLivroService.nRepositoryLivro.SelecionarTodos();
            return View(nListService);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (ModelState.IsValid)
            {
                //return View();
            }
            nLivroService.nRepositoryLivro.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Livro nLrivro = nLivroService.nRepositoryLivro.SelecionarPK(id);
            return View(nLrivro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            Livro nLrivro = nLivroService.nRepositoryLivro.Alterar(model);
            int id = nLrivro.Id;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Edit(int id)
        {
            Livro nLrivro = nLivroService.nRepositoryLivro.SelecionarPK(id);
            return View(nLrivro);
        }

        public IActionResult Delete(int id)
        {
            nLivroService.nRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
