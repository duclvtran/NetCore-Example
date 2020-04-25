using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IProductService
    {
        List<ProductModel> GetAll();
    }
}