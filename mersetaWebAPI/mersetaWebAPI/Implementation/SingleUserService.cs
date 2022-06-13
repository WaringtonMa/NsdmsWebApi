using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class SingleUserService : ISingleUser
    {
        private readonly mersetaContext MmersetaContext;

        public SingleUserService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<User> GetSingleUser(int id)
        {
            User user = new User();
            var uservar = MmersetaContext.Users.Where(x => x.Id == id).ToList();
            user = uservar[0];
            if (user != null)
            {
                return new Response<User>(user);
            }
            return new Response<User>(user);
        }
    }
}
