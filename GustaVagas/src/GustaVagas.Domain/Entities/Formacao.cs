using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class Formacao : Entity
    {
        public Formacao() : base()
        {

        }
        [StringLength(10)]
        public string TipoEnsino { get; set; }
        [StringLength(20)]
        public string Grau { get; set; }
        [StringLength(75)]
        public string Insituicao { get; set; }
        public int IdCandidato { get; set; }

        public Candidate Candidate { get; set; }
    }
}
