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
    public class CargoUserController : Controller
    {
        // GET: CargoUserController
        public ActionResult Index(string cpf)
        {
            CargoUserRepository repository = new();
            return View(repository.BuscarPorUsuario(cpf));
        }

        // GET: CargoUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CargoUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CargoUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] CargoUser cargoUsuario)
        {
            try
            {
                CargoRepository cargoRepository = new();
                Cargo cargo = cargoRepository.ProcurarCargo(cargoUsuario.Cargo.Nome);

                CandidateRepository candidateRepository = new();
                Candidate candidate = candidateRepository.BuscarPorCPF(cargoUsuario.Candidate.CPF);

                cargoUsuario.Cargo.Id = cargo.Id;
                cargoUsuario.Candidate.Id = candidate.Id;

                CargoUserRepository repository = new();
                repository.Add(cargoUsuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CargoUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CargoUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CargoUser cargoUser)
        {
            try
            {
                CargoUserRepository repository = new();
                repository.Update(cargoUser);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CargoUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CargoUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CargoUser cargoUser)
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
