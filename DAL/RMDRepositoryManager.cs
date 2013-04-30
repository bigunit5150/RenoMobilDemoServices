using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using RenoMobilDemoServices.Models;

namespace RenoMobilDemoServices.DAL
{
    public interface IRMDRepositoryManager : IDisposable
    {
        RMDBaseRepository<SewerLateralInspectionForm> SewerLateralInspectionForms { get; }

        void Save();
    }

    public class RMDRepositoryManager : IRMDRepositoryManager
    {
        private readonly RMDContext _context;
        private RMDBaseRepository<SewerLateralInspectionForm> _sewerLateralInspFormRepository; 


        private bool _disposed;

                public RMDRepositoryManager()
        {
            _context = new RMDContext();
        }

        public RMDRepositoryManager(RMDContext context)
        {
            _context = context;
        }

        public IDbConnection GetDbConnection()
        {
            return _context.Database.Connection;
        }

        public RMDContext GetContext()
        {
            return _context;
        }

        public RMDBaseRepository<SewerLateralInspectionForm> SewerLateralInspectionForms
        {
            get { return _sewerLateralInspFormRepository ?? (_sewerLateralInspFormRepository = new RMDBaseRepository<SewerLateralInspectionForm>(_context)); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #region Private
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        #endregion
    }
}