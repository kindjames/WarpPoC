using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Testing.Data.TestContexts
{
    public class AAABase
    {
        [SetUp]
        public void MainSetup()
        {
            Arrange();
            Act();
        }

        [TearDown]
        protected void MainTeardown()
        {
            CleanUp();
        }

        protected virtual void Act() { }
        protected virtual void Arrange() { }
        protected virtual void CleanUp() { }
    }
}
