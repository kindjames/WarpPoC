﻿using System;
using System.Data.Entity;
using System.IO;
using hGem.Data.Migrations;
using SpecsFor;
using SpecsFor.Configuration;
using SpecsFor.Mvc;

namespace hGem.Testing.Acceptance.Behaviors
{
    public class TestDatabaseInitializer : Behavior<SpecsFor<MvcWebApp>>
    {
        private static bool _isInitialized;
        
        public override void SpecInit(SpecsFor<MvcWebApp> instance)
        {
            if (!_isInitialized)
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());

                var strategy = new DropCreateDatabaseAlways<MigrationsAndTestingContext>();
                Database.SetInitializer(strategy);

                using (var context = new MigrationsAndTestingContext())
                {
                    context.Database.Initialize(true);
                }

                _isInitialized = true;
            }
        }
    }
}