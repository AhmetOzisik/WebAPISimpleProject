using ModelLayer.CustomersEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;
using WebAPI.GenericRepository;

namespace WebAPI.WebApiRepository
{
    public class CustomerRepository:GenericRepository<Customers>,ICustomersAPI
    {
    }
}
