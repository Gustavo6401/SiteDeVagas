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
    public class AreaUserController : Controller
    {
        // GET: AreaUserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AreaUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AreaUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AreaUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] AreaUser areaUser)
        {
            try
            {
                AreaRepository areaRepository = new();
                Area area = areaRepository.ProcurarArea(areaUser.Area.NameArea);

                CandidateRepository candidateRepository = new();
                Candidate candidate = candidateRepository.BuscarPorCPF(areaUser.Candidate.CPF);

                areaUser.Area.Id = area.Id;
                areaUser.Candidate.Id = candidate.Id;

                AreaUserRepository repository = new();
                repository.Add(areaUser);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AreaUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AreaUserController/Edit/5
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

        // GET: AreaUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AreaUserController/Delete/5
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
