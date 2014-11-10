using System;

namespace Warp.Data.Context
{
    public interface IHospitalityGemDbContextFactory
    {
        IHospitalityGemDbContext Build();
    }
}