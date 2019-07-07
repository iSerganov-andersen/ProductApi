using System;
using System.Collections.Generic;

namespace ProductCore.Entities
{
    public class Category : BaseEntity
    {
        private Category() { }
        public Category(String name, Guid? id = null)
        {
            Id = id.HasValue ? id.Value : Guid.NewGuid();
            Name = name;
            Products = new List<Product>();
        }
        public virtual ICollection<Product> Products { get; private set; }
        public void Rename(String newName)
        {
            Name = newName;
        }
    }
}
