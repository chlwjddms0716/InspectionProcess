using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    class ProductData : EntityData<Product>
    {
        public Product Get(int productId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.Products.FirstOrDefault(a => a.ProductId == productId);
        }

        public void Delete(int productId)
        {
            Product product = Get(productId);

            if (product == null)
                return;

            Delete(product);
        }

        public int GetMaxId()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Products
                        orderby x.ProductId descending
                        select x.ProductId;

            return query.FirstOrDefault();
        }
    }
}
