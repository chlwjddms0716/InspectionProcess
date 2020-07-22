using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class KeepingData : EntityData<Keeping>
    {
        public Keeping Get(int warehouseId, int inspectionResultId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.Keepings.FirstOrDefault(a => a.WarehouseId == warehouseId && a.InspectionResultId == inspectionResultId);
        }

        public void Delete(int warehouseId, int inspectionResultId)
        {
            Keeping keeping = Get(warehouseId, inspectionResultId);

            if (keeping == null)
                return;

            Delete(keeping);
        }

        public List<Keeping> Search(int? warehouseId, DateTime? keepFrom, DateTime? keepTo )
        {
            var context = CreateContext();

            var query = from x in context.Keepings
                        select new { Keeping = x, WarehouseName = x.Warehouse.Name };

            if (warehouseId.HasValue)
                query = query.Where(x => x.Keeping.WarehouseId == warehouseId);
            if (!keepTo.HasValue)
                keepTo = DateTime.Now;

            if (keepFrom.HasValue)
                query = query.Where(x => 
                   x.Keeping.KeepingDate >=keepFrom && x.Keeping.KeepingDate<=keepTo);

            var items = query.ToList();

            foreach (var x in items)
            {
                //x.Keeping.wa = x.MerchandiseName;
                //x.Product.TeamName = x.productionTeam;

            }

            return items.ConvertAll(x => x.Keeping);

        }
    }
}
