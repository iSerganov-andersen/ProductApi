using ProductCore.Entities;
using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServices.BusinessServices
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(AwesomeDbContext c)
            : base(c)
        {

        }
    }
}
