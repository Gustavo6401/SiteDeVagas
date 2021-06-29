using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
     public class Cargo : Entity 
     {
        public Cargo() : base()
        {

        }
        [StringLength(60)]
        public string Nome { get; set; }
        public Area Area { get; set; }
        public int IdArea { get; set; }
    }
}
