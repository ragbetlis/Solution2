using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            return new List<Customer>
            {
                new Customer {Id=1, FullName="Ali Al" },
                new Customer{Id=2, FullName="Veli Sat"},
                new Customer {Id=3, FullName="Ahmet Tart"}
            };
        }
    }
}
