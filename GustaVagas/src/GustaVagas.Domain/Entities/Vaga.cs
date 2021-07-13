using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class Vaga : Entity
    {
        public Vaga() : base()
        {

        }
        [StringLength(255)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        // O salário é uma ferramenta muito importante, pois ele pode ser o salário de um empregado, 
        // o dinheiro de um freelancer ou o dinheiro pelo contrato de uma empresa.
        [DataType("decimal(15, 2)")]
        public decimal Salario { get; set; }
        public int NumeroVagas { get; set; }
        public string Senioridade { get; set; }
        public string Escolaridade { get; set; }
        public EstadoVaga EstadoVaga { get; set; }
        public string LocalEntrevista { get; set; }
        public bool Remoto { get; set; }
        public bool Temporario { get; set; }
        public bool Freelance { get; set; }
        // Caso a vaga seja destinada para pessoa jurídica, o contratante deverá marcar este campo.
        public bool PessoaJuridica { get; set; }
        public Candidate Candidate { get; set; }
        public Enterprise Enterprise { get; set; }
        public Cargo Cargo { get; set; }
        public Area Area { get; set; }
        public int IdEnterprise { get; set; }
        public int IdCargo { get; set; }
        public int IdArea { get; set; }
    }
    public enum EstadoVaga
    {
        emAberto = 1,
        abertoACandidaturas = 2,
        emProcesso = 3,
        final = 4,
        fechada = 5, 
        excluída = 6,
    }
}
