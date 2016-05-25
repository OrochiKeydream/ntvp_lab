using System;
using NUnit.Framework;
using UMovement;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса UniformMovement.
    /// </summary>
    [TestFixture]
    public class UniformMovementTest
    {
        /// <summary>
        /// Тестирование конструктора.
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="time">Время</param>
        [Test]
        [TestCase(60.0, 60.0, TestName = "Тест конструктора с корректными" +
                                         " значениями")]
        public void UMovementPositiveTest(double speed, double time)
        {
            var obj = new UniformMovement(speed, time);
            Assert.AreEqual(obj.Speed, speed);
            Assert.AreEqual(obj.Time, time);
        }

        [Test]
        [TestCase(-60.0, 60.0, TestName = "Тест конструктора с" +
                                          " отрицательным значением" +
                                          " скорости")]
        [TestCase(60.0, -60.0, TestName = "Тест конструктора с" +
                                          " отрицательным значением" +
                                          " времени")]
        public void UMovementNegativeTest(double speed, double time)
        {
            Assert.Throws<ArgumentException>(()
                => new UniformMovement(speed, time));
        }
    }
}
