using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProductService : IProductService
    {
        public List<ProductModel> GetAll()
        {
            var list = new List<ProductModel>();
            list.Add(new ProductModel() { Id = 1, Name = "Mot" });
            list.Add(new ProductModel() { Id = 2, Name = "Hai" });
            list.Add(new ProductModel() { Id = 3, Name = "Ba" });
            return list;
        }
    }
}