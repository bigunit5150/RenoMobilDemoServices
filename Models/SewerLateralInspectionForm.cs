using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RenoMobilDemoServices.Models
{
    public class SewerLateralInspectionForm
    {
        public int SewerLateralInspectionFormId { get; set; }
        public string InspectorName { get; set; }
        public DateTime InspectionDate { get; set; }
        public string Street { get; set; }
        public string APNNumber { get; set; }
        public string GPSMain { get; set; }
        public string GPSCleanout { get; set; }
        public string LPipeId { get; set; }
        public Boolean LInstall { get; set; }
    }
}