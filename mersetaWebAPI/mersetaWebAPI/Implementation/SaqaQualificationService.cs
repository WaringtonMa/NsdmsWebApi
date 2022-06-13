using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class SaqaQualificationService : ISaqua
    {
        private readonly mersetaContext MmersetaContext;

        public SaqaQualificationService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }
        public Response<SaqaQualification> GetSaqaqualification(int id)
        {
            SaqaQualification saqa = new SaqaQualification();
            var uservar = MmersetaContext.SaqaQualifications.Where(x => x.Id == id).ToList();
            saqa = uservar[0];
            if (saqa != null)
            {
                return new Response<SaqaQualification>(saqa);
            }
            return new Response<SaqaQualification>(saqa);
        }
    }
}
