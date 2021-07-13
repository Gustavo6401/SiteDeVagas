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
    public class CargoController : Controller
    {
        // GET: CargoController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CargoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CargoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CargoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Nome,Area.NameArea")] Cargo cargo)
        {
            try
            {
                AreaRepository areaRepository = new();
                Area area = areaRepository.ProcurarArea(cargo.Area.NameArea);

                cargo.Area.Id = area.Id;

                CargoRepository repository = new();
                repository.Add(cargo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CargoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CargoController1/Edit/5
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

        // GET: CargoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CargoController1/Delete/5
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
