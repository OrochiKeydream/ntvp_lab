using System;
using NUnit.Framework;
using AMovement;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса AccelerationMovement.
    /// </summary>
    [TestFixture]
    public class AccelerationMovementTest
    {
        /// <summary>
        /// Тестирование конструктора.
        /// </summary>
        /// <param name="accel">Ускорение</param>
        /// <param name="time">Время</param>
        [Test]
        [TestCase(10.0, 10.0, TestName = "Тест конструктора с корректными" +
                                         " значениями")]
        public void AMovementPositiveTest(double accel, double time)
        {
            var obj = new AccelerationMovement(accel, time);
            Assert.AreEqual(obj.Acceleration, accel);
            Assert.AreEqual(obj.Time, time);
        }

        [Test]
        [TestCase(-10.0, 10, TestName = "Тест конструктора с" +
                                          " отрицательным значением" +
                                          " ускорения")]
        [TestCase(10.0, -10.0, TestName = "Тест конструктора с" +
                                          " отрицательным значением" +
                                          " времени")]
        public void AMovementNegativeTest(double accel, double time)
        {
            Assert.Throws<ArgumentException>(()
                => new AccelerationMovement(accel, time));
        }
    }
}
