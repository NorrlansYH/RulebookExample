using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]

    public class Testlevel
    {
        Wizard PaladinJakob = new Wizard();

        
        [Test]
        public void GetNewLevel()
        {
            PaladinJakob.Level = 3;
            PaladinJakob.Level ++;    
            
            Assert.That(PaladinJakob.Level, Is.EqualTo(4) );
        }
    }
}