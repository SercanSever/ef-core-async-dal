using AsyncProgramming.Data.DataAccees;
using AsyncProgramming.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Data.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
