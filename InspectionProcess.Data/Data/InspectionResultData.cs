using System;
using System.Collections.Generic;
using System.Linq;
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
