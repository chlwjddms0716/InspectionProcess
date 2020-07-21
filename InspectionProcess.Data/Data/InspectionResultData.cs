using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class InspectionResultData : EntityData<InspectionResult>
    {
        public InspectionResult Get(int inspectionResultId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.InspectionResults.FirstOrDefault(a => a.InspectionResultId == inspectionResultId);
        }

        public void Delete(int inspectionResultId)
        {
            InspectionResult inspectionResult = Get(inspectionResultId);

            if (inspectionResult == null)
                return;

            Delete(inspectionResult);
        }

        public List<InspectionResult> SearchByQuality(int? inspectionId, int? productId, int? InspectionTeamId)
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.InspectionResults
                        select new
                        {
                            InspectionResult = x,
                            MerchandiseName = x.Product.Merchandise.Name,
                            InspectionTeamName = x.Inspection.Team.Name,
                        };

            if (inspectionId.HasValue)
                query = query.Where(x => x.InspectionResult.Inspection.InspectionId == inspectionId);
            if (productId.HasValue)
                query = query.Where(x => x.InspectionResult.ProductId == productId);
            

                var list = query.ToList();

            foreach (var x in list)
            {
                x.InspectionResult.MerchandiseName = x.MerchandiseName;
                x.InspectionResult.InspectionTeamName = x.InspectionTeamName;
            }

            return list.ConvertAll(x => x.InspectionResult);
        }

        public int GetMaxId()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.InspectionResults
                        orderby x.InspectionResultId descending
                        select x.InspectionResultId;

            return query.FirstOrDefault();
        }
    }
}
