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
    public class CandidateController : Controller
    {
        // GET: CandidateController
        public IActionResult Index()
        {
            CandidateRepository repository = new();
            return View(repository.Get());
        }

        // GET: CandidateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Email,Celular,TelefoneFixo,Instagram,Linkedin,Github,Youtube,CEP,Rua,Numero,Cidade,Estado,CPF,RG,DataNascimento,EstaContratado,Descricao,Empresa,Escolaridade,EstadoCivil,Sexo,Senioridade,Usuario,PretencaoSalarialMinima,PretencaoSalarialMaxima")] Candidate pessoa)
        {
            try
            {
                UsuarioRepository userRepository = new();
                Usuario user = userRepository.FazerLogin(pessoa.Usuario.EMail, pessoa.Usuario.Password);

                pessoa.Usuario.Id = user.Id;

                CandidateRepository repository = new();
                repository.Add(pessoa);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CandidateController/Details
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandidateController/Edit
        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Edit(int id, Candidate candidate)
        {
            try
            {
                CandidateRepository repository = new();
                repository.Update(candidate);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Candidate candidate)
        {
            try
            {
                CandidateRepository repository = new();
                repository.Delete(candidate);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
