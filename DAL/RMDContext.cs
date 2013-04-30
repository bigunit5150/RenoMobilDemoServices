using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RenoMobilDemoServices.Models;

namespace RenoMobilDemoServices.DAL
{
    public class RMDContext : DbContext
    {
        #region Members
          public DbSet<SewerLateralInspectionForm> SewerLateralInspectionForms { get; set; }
        #endregion

        #region Public
        #endregion
        #region Private
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
        #endregion
    }
}