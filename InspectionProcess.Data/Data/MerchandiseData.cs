using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    class MerchandiseData : EntityData<Merchandise>
    {
        public Merchandise Get(int merchandiseId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.Merchandises.FirstOrDefault(a => a.MerchandiseId == merchandiseId);
        }

        public void Delete(int merchandiseId)
        {
            Merchandise merchandise = Get(merchandiseId);

            if (merchandise == null)
                return;

            Delete(merchandise);
        }

        public int GetMaxId()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Merchandises
                        orderby x.MerchandiseId descending
                        select x.MerchandiseId;

            return query.FirstOrDefault();
        }
    }
}
