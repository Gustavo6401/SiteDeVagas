using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GustaVagas.Infra.Repositories;
using GustaVagas.Domain.Entities;

namespace GustaVagas.Presentation.WebApplication.Controllers
{
    public class FormacaoController : Controller
    {
        // GET: FormacaoController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Formacao formacao)
        {
            ProjectRepository repository = new();
            return View(repository.BuscarPorAutor(formacao.Candidate.CPF));
        }

        // GET: FormacaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormacaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormacaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Formacao formacao)
        {
            try
            {
                CandidateRepository candidateRepository = new();
                Candidate candidate = candidateRepository.BuscarPorCPF(formacao.Candidate.CPF);

                formacao.Candidate.Id = candidate.Id;

                FormacaoRepository repository = new();
                repository.Add(formacao);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FormacaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormacaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FormacaoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormacaoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
