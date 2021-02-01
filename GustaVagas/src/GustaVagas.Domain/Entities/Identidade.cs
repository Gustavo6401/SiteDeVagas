using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class Identidade : Entity
    {
        public Identidade() : base ()
        {

        }
        [StringLength(100)]
        public string EMail { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(18)]
        public string RecoverPhone { get; set; }
        [StringLength(100)]
        public string RecoverEMail { get; set; }
    }
}
