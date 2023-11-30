using NUnit.Framework;
using Singleton;

namespace Singleton_Tests
{
    [TestFixture]
    public class WhenSingletonIsCalled
    {

        [Test]
        public void 

        [Test]
        public void ThenInitializationLogEntryIsAdded() 
        {

            //Logger
        }

    }


    [TestFixture]
    public class WhenSingletonIsNotCalled
    {
        [Test]
        public void ThenNoEntryAboutInitializationIsPresent() 
        {
            var logs = Logger.GetLog();
            Assert.
        }
    }
}
