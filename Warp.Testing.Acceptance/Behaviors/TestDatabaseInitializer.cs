using System;
using System.Data.Entity;
using System.IO;
using SpecsFor;
using SpecsFor.Configuration;
using SpecsFor.Mvc;
using Warp.Data.Migrations;

namespace Warp.Testing.Acceptance.Behaviors
{
    public class TestDatabaseInitializer : Behavior<SpecsFor<MvcWebApp>>
    {
        private static bool _isInitialized;
        
        public override void SpecInit(SpecsFor<MvcWebApp> instance)
        {
            if (!_isInitialized)
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());

                var strategy = new DropCreateDatabaseAlways<InternalMigrationsInitializationContext>();
                Database.SetInitializer(strategy);

                using (var context = new InternalMigrationsInitializationContext())
                {
                    context.Database.Initialize(true);
                }

                _isInitialized = true;
            }
        }
    }
}