using InspectionProcess.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class EntityData<T> where T : class
    {
        protected InspectionProcessEntities CreateContext()
        {
            InspectionProcessEntities context = new InspectionProcessEntities();
            context.Configuration.ProxyCreationEnabled = false;
            context.Database.Log = x => Console.WriteLine(x);

            return context;
        }


        public int GetCount()
        {
            InspectionProcessEntities context = CreateContext();

            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            InspectionProcessEntities context = CreateContext();

            //context.Albums.Add(album);
            context.Entry(entity).State = EntityState.Added;

            context.SaveChanges();
        }

        public void Update(T entity)
        {
            InspectionProcessEntities context = CreateContext();

            context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            InspectionProcessEntities context = CreateContext();

            context.Entry(entity).State = EntityState.Deleted;

            context.SaveChanges();
        }
    }
}
