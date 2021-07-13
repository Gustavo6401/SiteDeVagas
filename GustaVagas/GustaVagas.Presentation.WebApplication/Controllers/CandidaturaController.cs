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
    public class CandidaturaController : Controller
    {
        // GET: CandidaturaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CandidaturaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandidaturaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidaturaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("")] Candidatura candidatura)
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

        // GET: CandidaturaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandidaturaController/Edit/5
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

        // GET: CandidaturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CandidaturaController/Delete/5
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
