using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RenoMobilDemoServices.DAL;
using RenoMobilDemoServices.Models;

namespace RenoMobilDemoServices.Controllers
{
    public class SewerLateralInspectionFormController : ApiController
    {
        static readonly IRMDRepositoryManager _repository = new RMDRepositoryManager();

        public void Post(SewerLateralInspectionForm form)
        {
            form.InspectionDate = DateTime.Now;
            _repository.SewerLateralInspectionForms.Insert(form);
            _repository.Save();
        }

        public SewerLateralInspectionForm GetAll()
        {
            return new SewerLateralInspectionForm
                {
                    APNNumber = "1",
                    GPSCleanout = "3",
                    GPSMain = "4"
                };
        }
    }
}
