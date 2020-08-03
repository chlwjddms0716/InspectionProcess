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
        public List<InspectionResult> GetInspectionResults()
        {
            return DataRepository.InspectionResult.GetAll();
        }

        // GET: api/InspectionResult/5
        [ResponseType(typeof(InspectionResult))]
        public IHttpActionResult GetInspectionResult(int id)
        {
            InspectionResult inspectionResult = DataRepository.InspectionResult.Get(id);
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
            try
            {
                DataRepository.InspectionResult.Update(inspectionResult);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/InspectionResult
        [ResponseType(typeof(InspectionResult))]
        public IHttpActionResult PostInspectionResult(InspectionResult inspectionResult)
        {
            try
            {
                DataRepository.InspectionResult.Insert(inspectionResult);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

            return CreatedAtRoute("DefaultApi", new { id = inspectionResult.InspectionResultId }, inspectionResult);
        }

        // DELETE: api/InspectionResult/5
        [ResponseType(typeof(InspectionResult))]
        public IHttpActionResult DeleteInspectionResult(int id)
        {
            InspectionResult inspectionResult = DataRepository.InspectionResult.Get(id);

            if (inspectionResult == null)
                return NotFound();

            try
            {
                DataRepository.InspectionResult.Delete(inspectionResult);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

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