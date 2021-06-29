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
        [StringLength(45)]
        public string Area { get; set; }
        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
    }
}