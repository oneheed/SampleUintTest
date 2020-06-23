using NUnit.Framework;
using WebApplication1.Interfaces;
using WebApplication1.Services;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        private IService _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Service();
        }

        [TestCase(1.0, 2.0, 3.0, TestName = "Test 1 Add 2, Check:3")]
        public void TestAdd(decimal itemA, decimal itemB, decimal expected)
        {
            // Act
            var actual = _target.Add(itemA, itemB);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3.0, 1.0, 2.0, TestName = "Test 3 Minus 1, Check:2")]
        [TestCase(1.0, 3.0, -2.0, TestName = "Test 1 Minus 3, Check:-2")]
        public void TestMinus(decimal itemA, decimal itemB, decimal expected)
        {
            // Act
            var actual = _target.Minus(itemA, itemB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3.0, 2.0, 6.0, TestName = "Test 3 Times 2, Check:6")]
        public void TestTimes(decimal itemA, decimal itemB, decimal expected)
        {
            // Act
            var actual = _target.Times(itemA, itemB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6.0, 2.0, 3.0, TestName = "Test 6 Divided 2, Check:3")]
        public void TestDivided(decimal itemA, decimal itemB, decimal expected)
        {
            // Act
            var actual = _target.Divided(itemA, itemB);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
