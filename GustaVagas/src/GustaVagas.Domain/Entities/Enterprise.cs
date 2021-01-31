using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class Enterprise : Entity
    {
        public Enterprise() : base() 
        {

        }
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(80)]
        public string EMail { get; set; }
        [StringLength(18)]
        public string Telefone { get; set; }
        [StringLength(20)]
        public string Celular { get; set; }
        [DataType("char(18)")]
        public string CNPJ { get; set; }
        [DataType("char(9)")]
        public string CEP { get; set; }
        [StringLength(80)]
        public string Rua { get; set; }
        [StringLength(20)]
        public string Bairro { get; set; }
        [StringLength(25)]
        public string Cidade { get; set; }
        [DataType("char(2)")]
        public string Estado { get; set; }
        [StringLength(16)]
        public string País { get; set; }
        public int LoginId { get; set; }
    }
}
