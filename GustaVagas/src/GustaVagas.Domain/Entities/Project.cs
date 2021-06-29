using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities 
{
    public class Project 
    {
        public Project() : base() 
        {

        }
        [StringLength(100)] 
        public string Name { get; set; }
        public string URL { get; set; }
        [StringLength(35)]
        public string Tipo { get; set; }
        public bool PessoaJuridica { get; set; }
        public bool TemCliente { get; set; }
        public string Cliente { get; set; }
        public DateTime Comeco { get; set; }
        public DateTime Fim { get; set; }
        public Area Area { get; set; }
        public Candidate Candidato { get; set; }
        public Enterprise Empresa { get; set; }
        public int IdUsuario { get; set; }
    }
}