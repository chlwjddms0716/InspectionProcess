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

    }
}
