using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Midas.ObjectModel.Models;
using NUnit.Framework;

namespace Midas.Core.Test
{
    [TestFixture]
    public class ModelTest
    {
        [Test]
        public void CanSaveSecurity()
        {
            using(var dbContext = new MidasContext())
            {
                var security = new Security
                               {
                                   SecurityCode = "Test"
                               };

                dbContext.Securities.Add(security);

                dbContext.SaveChanges();

                var test = dbContext.Securities.Where(x => x.SecurityCode == "Test");

                Assert.IsNotEmpty(test);
            }
        }
    }
}
