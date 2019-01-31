using Datalayer.Models;
using Datalayer.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Datalayer.Repositories {
    public class FormalPostRepository : Repository<FormalPostModel, int> {
        public FormalPostRepository(ApplicationDbContext context) : base(context) { }

        public List<FormalPostModel> GetAllPostsForUserById(string userId) {
            return items.Where((p) => p.PostFromUserId.Equals(userId)).OrderByDescending((p) => p.TimePosted).ToList();
        }        
    }
}
