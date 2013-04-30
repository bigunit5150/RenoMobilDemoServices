using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RenoMobilDemoServices.DAL
{
    public class RMDInitializer : DropCreateDatabaseIfModelChanges<RMDContext>
    {
    }
}