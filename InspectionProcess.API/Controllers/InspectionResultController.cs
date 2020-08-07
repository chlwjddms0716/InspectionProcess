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
using System.Windows.Forms;
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
            InspectionResult _inspectionResult = DataRepository.InspectionResult.Get(id);
            _inspectionResult.NormalNumber = inspectionResult.NormalNumber;
            _inspectionResult.DefectiveNumber = inspectionResult.DefectiveNumber;
            _inspectionResult.Count = _inspectionResult.Count+1;

            
            if (_inspectionResult.Count == 3 && _inspectionResult.NormalNumber == 10) {
                InsertKeeping(_inspectionResult);

            }
            try
            {
                DataRepository.InspectionResult.Update(_inspectionResult);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        private void InsertKeeping(InspectionResult inspectionResult)
        {
            Keeping _keeping = new Keeping();
            WriteToEntity(_keeping, inspectionResult,0);

            Keeping _dumpKeeping = new Keeping();
            WriteToEntity(_dumpKeeping, inspectionResult,1);
            IncreaseWarehouse(_keeping, _dumpKeeping, inspectionResult);

            DataRepository.Keeping.Insert(_keeping);
            DataRepository.Keeping.Insert(_dumpKeeping);
        }

        private void IncreaseWarehouse(Keeping keeping, Keeping dumpkeeping, InspectionResult inspectionResult)
        {
            Warehouse warehouse = DataRepository.Warehouse.Get(keeping.WarehouseId);
            warehouse.Count += inspectionResult.NormalNumber;
            DataRepository.Warehouse.Update(warehouse);

            Warehouse dumpWarehouse = DataRepository.Warehouse.Get(dumpkeeping.WarehouseId);
            dumpWarehouse.Count += inspectionResult.DefectiveNumber;
            DataRepository.Warehouse.Update(dumpWarehouse);
        }

        private void WriteToEntity(Keeping keeping, InspectionResult inspectionResult, int isDefect)
        {
            keeping.InspectionResultId = inspectionResult.InspectionResultId;
            if (isDefect == 0)
                keeping.WarehouseId = DataRepository.Warehouse.Get(1).Count >= 100 ?
                    (DataRepository.Warehouse.Get(2).Count >= 100 ?
                    3: 2): 1;
            else
                keeping.WarehouseId = DataRepository.Warehouse.Get(4).Count >= 100 ? 5 : 4;
            keeping.KeepingDate = DateTime.Now;
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