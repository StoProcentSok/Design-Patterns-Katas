using NUnit.Framework;
using Singleton;
using System.Reflection;

namespace Singleton_Tests
{
    [TestFixture]
    public class WhenSingletonIsNotCalled
    {
        [Test]
        public void ThenNoEntryAboutInitializationIsPresent()
        {
            Logger.Clear();
            var logs = Logger.GetLog();
            Assert.IsEmpty(logs);
        }

        [Test]
        public void ThenSingletonObjectIsNullUntilCalled()
        {
            Type singletonType = typeof(Singleton.Singleton);
            FieldInfo? fieldInfo = singletonType.GetField("singletonInstance");
            Assert.IsNull(fieldInfo);

            var result = Singleton.Singleton.SingletonInstance;
            Assert.NotNull(result);

            Assert.True(result is Singleton.Singleton);
        }
    }
}
