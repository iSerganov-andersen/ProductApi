using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductCore.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        public String Name { get; protected set; }
    }
}
