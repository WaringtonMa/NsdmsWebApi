using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Implementation
{
    public class TownService : ITowns
    {
        private readonly mersetaContext MmersetaContext;

        public TownService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<List<Town>> GetAllTowns()
        {
            List<Town> town = new List<Town>();
            town.AddRange(MmersetaContext.Towns.OrderByDescending(x => x.Id).Take(10).ToList());

            if (town != null)
            {
                return new Response<List<Town>>(town);
            }
            return new Response<List<Town>>(town);
        }
    }
}
