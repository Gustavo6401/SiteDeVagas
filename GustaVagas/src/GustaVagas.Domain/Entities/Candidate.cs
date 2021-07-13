using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class Candidate : Entity
    {
        public Candidate() : base()
        {

        }
        [StringLength(75)]
        public string Name { get; set; }
        [StringLength(90)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Celular { get; set; }
        [StringLength(18)]
        public string TelefoneFixo { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public string YouTube { get; set; }
        [DataType("char(9)")]
        public string CEP { get; set; }
        [StringLength(80)]
        public string Rua { get; set; }
        [StringLength(25)]
        public string Bairro { get; set; }
        public int Numero { get; set; }
        [StringLength(20)]
        public string Cidade { get; set; }
        [DataType("char(2)")]
        public string Estado { get; set; }
        [DataType("char(14)")]
        public string CPF { get; set; }
        [DataType("char(12)")]
        public string RG { get; set; }
        [DataType("date")]
        public DateTime DataNascimento { get; set; }
        public bool EstáContratado { get; set; }
        [DataType("nvarchar(max)")]
        public string DescricaoCandidato { get; set; }
        [StringLength(25)]
        public string Empresa { get; set; }
        [StringLength(20)]        
        public string Escolaridade { get; set; } // Escolaridade do candidato.
        [StringLength(10)]
        public string EstadoCivil { get; set; }
        [StringLength(12)]
        public string Sexo { get; set; }
        [StringLength(6)]
        public string Senioridade { get; set; } // Se ele é trainee, operacional, júnior, pleno ou sênior.
        public Usuario Usuario { get; set; }
        //public int IdUsuario { get; set; }
        [DataType("decimal(15, 2)")]
        public decimal PretencaoSalarialMinima { get; set; }
        [DataType("decimal(15, 2)")]
        public decimal PretencaoSalarialMaxima { get; set; }
    }
}
