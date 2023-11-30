using NUnit.Framework;
using Singleton;
using System.Reflection;

namespace Singleton_Tests
{
    [TestFixture]
    public class WhenSingletonIsCalled
    {


        [Test]
        public void ThenInitializationLogEntryIsAdded() 
        {

            var singleton = Singleton.Singleton.SingletonInstance;
            var logs = Logger.GetLog();
            Assert.IsNotEmpty(logs);
            Assert.True(logs.Any(l => l.Contains(SingletonLoggerEntries.SingletonConstructorCalledEntry)));
        }

        [Test]
        public void ThenConstructorIsCalledOnlyOnce()
        {
            Logger.Clear();
            var first = Singleton.Singleton.SingletonInstance;
            var second = Singleton.Singleton.SingletonInstance;
            var third = Singleton.Singleton.SingletonInstance;


            var logs = Logger.GetLog();
            Assert.AreEqual(4, logs.Count);
            Assert.AreEqual(1, logs.Where(l => l.Contains(SingletonLoggerEntries.SingletonConstructorCalledEntry)).Count());
            Assert.AreEqual(3, logs.Where(l => l.Contains(SingletonLoggerEntries.SingletonInstanceReturnedEntry)).Count());
            
        }
    }


    [TestFixture]
    public class WhenSingletonIsNotCalled
    {
        [Test]
        public void ThenSingletonObjectIsNullUntilCalled()
        {
            Type singletonType = typeof(Singleton.Singleton);
            FieldInfo fieldInfo = singletonType.GetField("singletonInstance");
            Assert.IsNull(fieldInfo);

            var result = Singleton.Singleton.SingletonInstance;
            Assert.NotNull(result);

            Assert.True(result is Singleton.Singleton);
        }

        [Test]
        public void ThenNoEntryAboutInitializationIsPresent() 
        {
            Logger.Clear();
            var logs = Logger.GetLog();
            Assert.IsEmpty(logs);
        }
    }
}
