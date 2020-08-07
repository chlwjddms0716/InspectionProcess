using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class InspectionData : EntityData<Inspection>
    {
        public Task<Inspection> GetAsync(int inspectionId)
        {
            return Task.Factory.StartNew(() => Get(inspectionId));
        }

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

        public List<Inspection> GetAllbyDate(DateTime startDate, DateTime finishDate)
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Inspections
                        orderby x.InspectionId descending
                        where (x.FinishTime == null || x.FinishTime != null && x.StartTime >= startDate) ||
                                (x.FinishTime <= finishDate && x.StartTime >= startDate)
                        select x;
            return query.ToList();
        }

        public int GetbyId(int inspectionId)
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Inspections
                        where x.InspectionId == inspectionId
                        select x.InspectionId;

            return query.FirstOrDefault();
        }
    }
}
