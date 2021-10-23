using AsyncProgramming.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Business.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
    }
}
