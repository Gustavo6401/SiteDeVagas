using System;
using System.ComponentModel.DataAnnotations;
using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities 
{
    public class Usuario : Entity 
    {
        public Usuario() : base() 
        {

        }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string EMail { get; set; }   
        [StringLength(50)]
        public string Password { get; set; }  
    }
}