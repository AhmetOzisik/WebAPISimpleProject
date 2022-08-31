using ModelLayer.CustomersEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Abstract
{
    public interface ICustomersAPI : IWebApiGeneric<Customers>
    {
    }
}
