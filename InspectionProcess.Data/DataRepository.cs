using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class DataRepository
    {
        public static InspectionData Inspection { get; } = new InspectionData();

        public static InspectionResultData InspectionResult { get; } = new InspectionResultData();

        public static KeepingData Keeping { get; } = new KeepingData();
        public static MerchandiseData Merchandise { get; } = new MerchandiseData();
        public static ProductData Product { get; } = new ProductData();
        public static TeamData Team { get; } = new TeamData();

        public static WarehouseData Warehouse { get; } = new WarehouseData();


    }
}
