using System;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class CargoUser : Entity
    {
        public CargoUser() : base()
        {

        }
        public Cargo Cargo { get; set; }
        public Candidate Candidate { get; set; }
    }
}
