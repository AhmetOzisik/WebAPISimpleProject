using ModelLayer.CustomersEntities;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Abstract
{
    public interface IOrderAPI : IWebApiGeneric<Orders>
    {
    }
}
