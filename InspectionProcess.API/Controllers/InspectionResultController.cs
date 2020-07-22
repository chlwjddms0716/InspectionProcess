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
    public class InspectionResultController : ApiController
    {
        private InspectionProcessEntities db = new InspectionProcessEntities();

        // GET: api/InspectionResult
        public IQueryable<InspectionResult> GetInspectionResults()
        {
            return db.InspectionResults;
        }

        // GET: api/InspectionResult/5
        [ResponseType(typeof(InspectionResult))]
        public IHttpActionResult GetInspectionResult(int id)
        {
            InspectionResult inspectionResult = db.InspectionResults.Find(id);
            if (inspectionResult == null)
            {
                return NotFound();
            }

            return Ok(inspectionResult);
        }

        // PUT: api/InspectionResult/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInspectionResult(int id, InspectionResult inspectionResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inspectionResult.InspectionResultId)
            {
                return BadRequest();
            }

            db.Entry(inspectionResult).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionResultExists(id))
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

        // POST: api/InspectionResult
        [ResponseType(typeof(InspectionResult))]
        public IHttpActionResult PostInspectionResult(InspectionResult inspectionResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InspectionResults.Add(inspectionResult);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InspectionResultExists(inspectionResult.InspectionResultId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = inspectionResult.InspectionResultId }, inspectionResult);
        }

        // DELETE: api/InspectionResult/5
        [ResponseType(typeof(InspectionResult))]
        public IHttpActionResult DeleteInspectionResult(int id)
        {
            InspectionResult inspectionResult = db.InspectionResults.Find(id);
            if (inspectionResult == null)
            {
                return NotFound();
            }

            db.InspectionResults.Remove(inspectionResult);
            db.SaveChanges();

            return Ok(inspectionResult);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InspectionResultExists(int id)
        {
            return db.InspectionResults.Count(e => e.InspectionResultId == id) > 0;
        }
    }
}