using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class AreaUser : Entity
    {
        public AreaUser() : base()
        {

        }
        public int AreaId { get; set; }
        public int UserId { get; set; }

        public Area Area { get; set; }
        public Candidate Candidate { get; set; }
    }
}
