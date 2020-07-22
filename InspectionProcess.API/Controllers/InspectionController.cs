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
            try
            {
                DataRepository.Inspection.Update(inspection);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Inspection
        [ResponseType(typeof(Inspection))]
        public IHttpActionResult PostInspection(Inspection inspection)
        {
            try
            {
                DataRepository.Inspection.Insert(inspection);
            }
            catch (Exception ex) { 

                return BadRequest();
            }

            return CreatedAtRoute("DefaultApi", new { id = inspection.InspectionId }, inspection);
        }

        // DELETE: api/Inspection/5
        [ResponseType(typeof(Inspection))]
        public IHttpActionResult DeleteInspection(int id)
        {
            Inspection inspection = DataRepository.Inspection.Get(id);

            if (inspection == null)
                return NotFound();

            try
            {
                DataRepository.Inspection.Delete(inspection);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

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