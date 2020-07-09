using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.User
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
