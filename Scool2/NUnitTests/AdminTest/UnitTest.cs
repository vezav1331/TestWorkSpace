using NUnit.Framework;
using School.AdminFiles;
using System.Linq;

namespace NUnitTests.AdminTest
{
    /// <summary>
    /// Тесты методов сервиса
    /// </summary>
    [TestFixture(Description = "Тесты методов сервиса")]
    public class UnitTest
    {
        /// <summary>
        /// 
        /// </summary>
        private ServiceForTest _serviceForTestMock;

        /// <summary>
        /// Setup
        /// </summary>
        [SetUp]
        public void LocalSetup()
        {
            _serviceForTestMock = new ServiceForTest();
        }

        /// <summary>
        /// Успешный тест
        /// </summary>
        [Test(Description = "Успешный тест")]
        public void Succesful()
        {
            var result = _serviceForTestMock.TestMethod1(10, 10);

            Assert.IsNotEmpty(result);
            Assert.AreEqual(result.Count(), 2);
        }

        /// <summary>
        /// Test1
        /// </summary>
        [Test(Description = "Test1")]
        public void Test1()
        {
            var result = _serviceForTestMock.TestMethod1(5, 5);

            Assert.AreEqual(result.Count(), 1);
            Assert.AreEqual(result.First(), -100);
        }

        /// <summary>
        /// Test2
        /// </summary>
        [Test(Description = "Test2")]
        public void Test2()
        {
            var result = _serviceForTestMock.TestMethod1(15, 15);

            Assert.AreEqual(result.Count(), 1);
            Assert.AreEqual(result.First(), 100);
        }
    }
}
