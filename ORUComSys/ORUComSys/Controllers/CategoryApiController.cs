using Datalayer.Models;
using Datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace ORUComSys.Controllers
{
    [RoutePrefix("api/cate")]
    public class CategoryApiController : ApiController
    {
        private CategoryRepository categoryRepository;

        public CategoryApiController()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            categoryRepository = new CategoryRepository(context);
        }
        [HttpGet]
        [Route("getCate")]
        public List<CategoryModels> GetCate() {
          return categoryRepository.GetAll();
             
        }
        [HttpPost]
        [Route("AddCate")]
        public void AddCate(string cate)
        {
            if (cate != null || cate == "")
            {
                var cateList = categoryRepository.GetAll();
                if (cateList.Count > 0)
                {
                    foreach (var item in cateList)
                    {
                        if (item.Name != cate)
                        {
                            categoryRepository.Add(new CategoryModels
                            {
                                Name = cate
                            });
                            categoryRepository.Save();
                        }
                    }
                }
                if (cateList.Count == 0 || cateList == null)
                {
                    categoryRepository.Add(new CategoryModels
                    {
                        Name = cate
                    });
                    categoryRepository.Save();
                }
            }
        }
    }
}
