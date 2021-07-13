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
    public class ProjectController : Controller
    {
        // GET: ProjectController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Project project)
        {
            if(project.PessoaJuridica)
            {
                ProjectRepository repository = new();
                return View(repository.BuscarPorAutor(project.Candidato.CPF));
            }
            else
            {
                ProjectRepository repository = new();
                return View(repository.BuscarPorEmpresa(project.Empresa.CNPJ));
            }
            
        }

        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Project project)
        {
            try
            {
                CandidateRepository candidateRepository = new();
                EnterpriseRepository enterpriseRepository = new();
                Candidate candidate;
                Enterprise enterprise;

                if (project.PessoaJuridica)
                {
                    enterprise = enterpriseRepository.BuscarPorCNPJ(project.Empresa.CNPJ);
                    project.Empresa.Id = enterprise.Id;
                }
                else
                {                     
                    candidate = candidateRepository.BuscarPorCPF(project.Candidato.CPF);
                    project.Candidato.Id = candidate.Id;
                }

                ProjectRepository repository = new();
                repository.Add(project);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectController/Edit/5
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

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectController/Delete/5
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
