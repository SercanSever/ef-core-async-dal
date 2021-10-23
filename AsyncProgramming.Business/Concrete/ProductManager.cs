using AsyncProgramming.Business.Abstract;
using AsyncProgramming.Data.Abstract;
using AsyncProgramming.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productDal.GetAll();
        }
    }
}
