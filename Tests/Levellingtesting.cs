using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NUnit.Common;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Levellingtesting
    {
        [Test]
        public void WizardLevelsUp()
        {
            var wizard = new Wizard();
            wizard.Experience += 300d;
            Assert.That(wizard.Level, Is.AtLeast(2));
        }
    }
}
