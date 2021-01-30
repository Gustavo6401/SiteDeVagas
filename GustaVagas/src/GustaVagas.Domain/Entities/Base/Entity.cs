using System;
using System.ComponentModel.DataAnnotations;

namespace GustaVagas.Domain.Entities.Base
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
