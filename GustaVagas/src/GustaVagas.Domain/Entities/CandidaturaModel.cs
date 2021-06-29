using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class CandidaturaModel : Entity
    {
        public CandidaturaModel() : base()
        {

        }
        public int IdVaga { get; set; }
        public int IdUser { get; set; }
        public int IdEmpresa { get; set; }

        public Vaga Vaga { get; set; }
        public Usuario Usuario { get; set; }
        public Enterprise Enterprise { get; set; }
    }
}
