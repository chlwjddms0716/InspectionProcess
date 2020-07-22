using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using InspectionProcess.Data;

namespace InspectionProcess.API.Controllers
{
    public class InspectionController : ApiController
    {
        private InspectionProcessEntities db = new InspectionProcessEntities();

        // GET: api/Inspection
        public List<Inspection> GetInspections()
        {
            return DataRepository.Inspection.GetAll();
        }

        // GET: api/Inspection/5
        [ResponseType(typeof(Inspection))]
        public IHttpActionResult GetInspection(int id)
        {
            Inspection inspection = DataRepository.Inspection.Get(id);

            if (inspection == null)
            {
                return NotFound();
            }

            return Ok(inspection);
        }

        // PUT: api/Inspection/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInspection(int id, Inspection inspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inspection.InspectionId)
            {
                return BadRequest();
            }

            db.Entry(inspection).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Inspection
        [ResponseType(typeof(Inspection))]
        public IHttpActionResult PostInspection(Inspection inspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Inspections.Add(inspection);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InspectionExists(inspection.InspectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = inspection.InspectionId }, inspection);
        }

        // DELETE: api/Inspection/5
        [ResponseType(typeof(Inspection))]
        public IHttpActionResult DeleteInspection(int id)
        {
            Inspection inspection = db.Inspections.Find(id);
            if (inspection == null)
            {
                return NotFound();
            }

            db.Inspections.Remove(inspection);
            db.SaveChanges();

            return Ok(inspection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InspectionExists(int id)
        {
            return db.Inspections.Count(e => e.InspectionId == id) > 0;
        }
    }
}