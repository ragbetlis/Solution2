using Business.Abstract;
using Business.DependencyReselvors;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.NewFolder
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager()
        {
            _productDal = (IProductDal)InstanceFactory<IProductDal>.GetDalInstance();
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
