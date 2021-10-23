using AsyncProgramming.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<List<Product>> GetByCategoryName(string name);
    }
}
