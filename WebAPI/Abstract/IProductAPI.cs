using ModelLayer.CustomersEntities;
using ModelLayer.ProductsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Abstract
{
    public interface IProductAPI : IWebApiGeneric<Products>
    {
    }
}
