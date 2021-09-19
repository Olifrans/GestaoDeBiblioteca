using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimo.Web.Controllers
{
    public class EmprestimosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
