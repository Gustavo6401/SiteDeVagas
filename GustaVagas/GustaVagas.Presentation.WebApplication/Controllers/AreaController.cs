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
    public class AreaController : Controller
    {
        // GET: AreaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AreaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AreaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AreaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,NameArea")] Area area)
        {
            try
            {
                AreaRepository repository = new();
                repository.Add(area);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AreaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AreaController/Edit/5
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

        // GET: AreaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AreaController/Delete/5
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
