using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {Id=1, Name="Portakal" },
                new Product{Id=2, Name="Elma"},
                new Product {Id=3, Name="Armut"}
            };
        }
    }
}
