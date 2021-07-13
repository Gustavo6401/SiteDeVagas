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
    public class VagasController : Controller
    {
        // GET: VagasController
        public ActionResult Index()
        {
            VagaRepository repository = new();
            return View(repository.Get());
        }

        // GET: VagasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VagasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VagasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Nome,Descricao,Salario,NumeroVagas,Senioridade,Escolaridade,EstadoVaga,LocalEntrevista,Remoto,Temporario,Freelance,PessoaJuridica,Enterprise,Cargo,Area")] Vaga vaga)
        {
            try
            {
                CandidateRepository candidateRepository = new();
                Candidate candidate = candidateRepository.BuscarPorCPF(vaga.Candidate.CPF);

                EnterpriseRepository enterpriseRepository = new();
                Enterprise enterprise = enterpriseRepository.BuscarPorCNPJ(vaga.Enterprise.CNPJ);

                AreaRepository areaRepository = new();
                Area area = areaRepository.ProcurarArea(vaga.Area.NameArea);

                CargoRepository cargoRepository = new();
                Cargo cargo = cargoRepository.ProcurarCargo(vaga.Cargo.Nome);

                vaga.Candidate.Id = candidate.Id;
                vaga.Enterprise.Id = enterprise.Id;
                vaga.Area.Id = area.Id;
                vaga.Cargo.Id = cargo.Id;

                VagaRepository repository = new();
                repository.Add(vaga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VagasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VagasController/Edit/5
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

        // GET: VagasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VagasController/Delete/5
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
