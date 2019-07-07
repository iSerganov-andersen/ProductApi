using ProductCore.Entities;
using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServices.BusinessServices
{
    public class CategoryService : BaseService<Category>
    {
        public CategoryService(AwesomeDbContext c)
            : base(c)
        {

        }
    }
}
