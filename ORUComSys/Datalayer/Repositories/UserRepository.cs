using Datalayer.Models;
using System.Linq;

namespace Datalayer.Repositories {
    public class UserRepository : Repository<ApplicationUser, string> {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public string GetUserIdByEmail(string email) {
            ApplicationUser user = items.First((u) => u.Email.Equals(email));
            return user.Id;
        }
    }
}