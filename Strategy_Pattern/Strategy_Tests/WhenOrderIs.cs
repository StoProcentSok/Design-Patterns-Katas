using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Tests
{
    [TestFixture]
    public class WhenOrderIs
    {
        [Test]
        public void FromSwedenThenTaxSHouldBeX()
        {
            Assert.True(true);
        }

        [Test]
        public void FromUSThenTaxSHouldBeY()
        {
            Assert.False(true);
        }
    }
}
