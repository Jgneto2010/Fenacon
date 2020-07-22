using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
