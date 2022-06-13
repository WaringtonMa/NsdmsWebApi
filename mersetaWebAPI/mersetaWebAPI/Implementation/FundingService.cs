using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class FundingService : IFunding
    {
        private readonly mersetaContext MmersetaContext;

        public FundingService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<Funding> GetFunding(int id)
        {
            Funding fund = new Funding();
            var fundvar = MmersetaContext.Fundings.Where(x => x.Id == id).ToList();
            fund = fundvar[0];
            if (fund != null)
            {
                return new Response<Funding>(fund);
            }
            return new Response<Funding>(fund);
        }
    }
}
