using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GustaVagas.Infra.Repositories;
using GustaVagas.Domain.Entities;

namespace GustaVagas.Presentation.WebApplication.Controllers
{
    public class EnterpriseController : Controller
    {
        // GET: EnterpriseController
        public IActionResult Index()
        {
            EnterpriseRepository repository = new();
            return View(repository.Get());
        }

        // GET: EnterpriseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnterpriseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,EMail,Telefone,Celular,CNPJ,CEP,Rua,Bairro,Cidade,Estado,Pais,Usuario")] Enterprise empresa)
        {
            try
            {
                UsuarioRepository userRepository = new();
                Usuario user = userRepository.FazerLogin(empresa.Usuario.EMail, empresa.Usuario.Password);

                empresa.Usuario.Id = user.Id;

                EnterpriseRepository repository = new();
                repository.Add(empresa);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
