using System.Diagnostics;

namespace Warp.Data.Context
{
    public class HospitalityGemDbContextFactory : IHospitalityGemDbContextFactory
    {
        public IHospitalityGemDbContext Build()
        {
            var db = new HospitalityGemDbContext();

            if (Debugger.IsAttached)
            {
                db.Database.Log = l => Debug.Write(l);
            }

            return db;
        }
    }
}