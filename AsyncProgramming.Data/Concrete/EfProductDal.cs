using AsyncProgramming.Data.Abstract;
using AsyncProgramming.Data.Context;
using AsyncProgramming.Data.DataAccees.EntityFramework;
using AsyncProgramming.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Data.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product>,IProductDal
    {
    }
}
