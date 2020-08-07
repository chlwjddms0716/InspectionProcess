using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class ProductData : EntityData<Product>
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

        public List<Product> Search(int? productionId, int? merchandiseId, int? teamId)
        {
            var context = CreateContext();

             var query = from x in context.Products
                        select new { Product = x,  MerchandiseName = x.Merchandise.Name/*, InspectionTeam = x.InspectionTeam */};

            if (productionId.HasValue)
                query = query.Where(x => x.Product.ProductId == productionId);

            if (merchandiseId.HasValue)
                query = query.Where(x => x.Product.MerchandiseId == merchandiseId);
            if (teamId.HasValue)
                query = query.Where(x => x.Product.ProductionTeam == teamId);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Product.MerchandiseName = x.MerchandiseName;
                //x.Product.TeamName = x.productionTeam;

            }

            return items.ConvertAll(x => x.Product);

        }

    }
}
