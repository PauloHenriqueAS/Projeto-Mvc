using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projetoFinalUdemy.Models;
using projetoFinalUdemy.Models.ViewModels;

namespace projetoFinalUdemy.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(1, "Eletronicos"));
            list.Add(new Department(2, "Jogos"));
            list.Add(new Department(3, "Papelaria"));
            list.Add(new Department(4, "Alimentos"));
            
            return View(list);
        }
    }
}