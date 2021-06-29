using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class Candidatura : Entity
    {
        public Candidatura() : base()
        {

        }
        /* Nessa tabela, será feita uma inteligência para saber se quem está candidatando-se é uma pessoa física, jurídica
         * e se a vaga é para pessoa física ou jurídica. */
        public int IdVaga { get; set; }
        public int IdOferecedor { get; set; }
        public int IdCandidato { get; set; }
        public bool ParaPJ { get; set; }
        public bool DePJ { get; set; }

        public Vaga Vaga { get; set; }
        public Candidate Candidato { get; set; }
        // Caso quem esteja oferecendo seja pessoa física.
        public Candidate OferecedorPF { get; set; }
        public Enterprise Enterprise { get; set; }
        // Caso o candidato seja pessoa jurídica.
        public Enterprise CandidatoPJ { get; set; }
    }
}
