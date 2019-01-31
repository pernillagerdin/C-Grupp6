using Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Repositories
{
    public class CategoryRepository : Repository<CategoryModels, int>
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        } 

    }
}
