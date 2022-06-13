using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Implementation
{
    public class UserService : IUsers
    {
        private readonly mersetaContext MmersetaContext;

        public UserService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<List<User>> GetAllUsers()
        {
            List<User> user = new List<User>();
            user.AddRange(MmersetaContext.Users.OrderByDescending(x => x.Id).Take(10).ToList());

            if (user != null)
            {
                return new Response<List<User>>(user);
            }
            return new Response<List<User>>(user);
        }
    }
}
