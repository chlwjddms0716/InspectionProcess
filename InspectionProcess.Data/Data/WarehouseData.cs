using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class WarehouseData : EntityData<Warehouse>
    {
        public Warehouse Get(int warehouseId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.Warehouses.FirstOrDefault(a => a.WarehouseId == warehouseId);
        }

        public Task<List<Warehouse>> GetbyDumpAsync()
        {
            return Task.Factory.StartNew(() => GetbyDump());
        }

        public List<Warehouse> GetbyDump()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Warehouses
                        where x.WarehouseId > 3
                        select x;

            return query.ToList();
        }

        public void Delete(int warehouseId)
        {
            Warehouse warehouse = Get(warehouseId);

            if (warehouse == null)
                return;

            Delete(warehouse);
        }

        public int GetMaxId()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Warehouses
                        orderby x.WarehouseId descending
                        select x.WarehouseId;

            return query.FirstOrDefault();
        }
    }
}
