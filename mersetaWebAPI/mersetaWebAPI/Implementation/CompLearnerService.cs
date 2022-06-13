using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class CompLearnerService : ICompLearner
    {
        private readonly mersetaContext MmersetaContext;

        public CompLearnerService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }
        public Response<CompanyLearner> GetSingCompLearner(int userid, int companyid)
        {
            List<CompanyLearner> company = new List<CompanyLearner>();
            CompanyLearner comp = new CompanyLearner();
            var compvar = MmersetaContext.CompanyLearners.
                Where(x => x.UserId == userid && x.CompanyId == companyid)
                 .Select(x => new { x.Id, x.CreateDate, x.CompanyId, x.UserId,x.QualificationId,x.EmployerId,x.ApprovalDate,x.LearnerStatus,
                 x.Status,x.InterventionTypeId,x.NqfAlignedId,x.NqfLevelsId,x.NqfLevels,x.CommencementDate,x.CompletionDate,x.TrainingProviderApplicationId,x.MersetaFunded,x.OfoCodesId,x.RegisteredDate,x.DundingId,x.ConditionalPlacementDate,x.SignedDate}).ToList();

            foreach (var c in compvar)
            {
                company.Add(new CompanyLearner { Id = c.Id, CreateDate = c.CreateDate, CompanyId = c.CompanyId, UserId = c.UserId, QualificationId = c.QualificationId, EmployerId = c.EmployerId , ApprovalDate = c.ApprovalDate, LearnerStatus =c.LearnerStatus, Status =c.Status,InterventionTypeId = c.InterventionTypeId, NqfAlignedId =c.NqfAlignedId, NqfLevelsId= c.NqfLevelsId,
                NqfLevels = c.NqfLevels,CommencementDate = c.CommencementDate,CompletionDate = c.CompletionDate,TrainingProviderApplicationId =c.TrainingProviderApplicationId,MersetaFunded =c.MersetaFunded,OfoCodesId =c.OfoCodesId,RegisteredDate =c.RegisteredDate,DundingId = c.DundingId,ConditionalPlacementDate =c.ConditionalPlacementDate,SignedDate=c.SignedDate});
            }

            comp = company[0];
            if (comp != null)
            {
                return new Response<CompanyLearner>(comp);
            }
            return new Response<CompanyLearner>(comp);
        }
    }
}
