using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCore.Entities
{
    public class Product : BaseEntity
    {
        private Product() { }
        public Product(string name, Category category, Decimal price, Guid? id = null)
        {
            Id = id.HasValue ? id.Value :  Guid.NewGuid();
            Name = name;
            IsActive = true;
            Category = category;
            Price = price;
        }
        public virtual Category Category { get; private set; }
        public bool IsActive { get; private set; }
        public decimal Price { get; private set; }
        public void Activate()
        {
            if (!IsActive)
                IsActive = true;
        }
        public void DeActivate()
        {
            if (IsActive)
                IsActive = false;
        }
        public void SetPrice(Decimal newPrice)
        {
            Price = newPrice;
        }
    }
}
