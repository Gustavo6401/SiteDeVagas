using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class EnterpriseProject : Entity
    {
        public EnterpriseProject() : base()
        {

        }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Cliente { get; set; }
        public string URL { get; set; }
        public Enterprise Enterprise { get; set; }
        public int IdEnterprise { get { return IdEnterprise } set { Enterprise.Id } }
    }
}
