using Business.Abstract;
using Business.Concrete.NewFolder;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyReselvors
{
   public static class InstanceFactory<T>
    {

        public static object GetManagerInstance()
        {
            var getType = typeof(T);
            
            if (getType != typeof(IProductService))
            {
                throw new Exception();
            }
            ProductManager productManager = new ProductManager();
            return productManager;
        }
        public static object GetDalInstance()
        {
            var getType = typeof(T);
            if (getType != typeof(IProductDal))
            {
                throw new Exception();
            }
            ProductDal productDal = new ProductDal();
            return productDal;
        }
    }
}
