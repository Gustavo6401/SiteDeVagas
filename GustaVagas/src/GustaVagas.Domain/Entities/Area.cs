using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    class Area : Entity
    {
        public Area() : base()
        {

        }
        [StringLength(25)]
        public string NameArea { get; set; }
    }
}
