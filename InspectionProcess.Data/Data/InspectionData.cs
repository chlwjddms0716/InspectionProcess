using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class InspectionData : EntityData<Inspection>
    {
        public Inspection Get(int inspectionId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.Inspections.FirstOrDefault(a => a.InspectionId == inspectionId);
        }

        public void Delete(int inspectionId)
        {
            Inspection inspection = Get(inspectionId);

            if (inspection == null)
                return;

            Delete(inspection);
        }

        public int GetMaxId()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Inspections
                        orderby x.InspectionId descending
                        select x.InspectionId;

            return query.FirstOrDefault();
        }

        public object GetAllbyDate(DateTime dateTime1, DateTime dateTime2)
        {
            throw new NotImplementedException();
        }
    }
}
