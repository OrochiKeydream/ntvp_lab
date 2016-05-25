using System;
using NUnit.Framework;
using OMovement;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса OscillatingMovement.
    /// </summary>
    [TestFixture]
    public class OscillatingMovementTest
    {
        /// <summary>
        /// Тестирование конструктора.
        /// </summary>
        /// <param name="amplitude">Амплитуда</param>
        /// <param name="frequency">Частота</param>
        /// <param name="phase">Фаза</param>
        /// <param name="time">Время</param>
        [Test]
        [TestCase(10.0, 10.0, 10.0, 10.0, TestName = "Тест конструктора с" +
                                                     " корректными" +
                                                     " значениями")]
        public void OMovementPositiveTest(double amplitude, double frequency,
            double phase, double time)
        {
            var obj = new OscillatingMovement(amplitude, frequency, phase,
                time);
            Assert.AreEqual(obj.Amplitude, amplitude);
            Assert.AreEqual(obj.Frequency, frequency);
            Assert.AreEqual(obj.Phase, phase);
            Assert.AreEqual(obj.Time, time);
        }

        [Test]
        [TestCase(-10.0, 10.0, 10.0, 10.0, TestName = "Тест конструктора с" +
                                                      " отрицательным" +
                                                      " значением" +
                                                      " амплитуды")]
        [TestCase(10.0, -10.0, 10.0, 10.0, TestName = "Тест конструктора с" +
                                                      " отрицательным" +
                                                      " значением" +
                                                      " частоты")]
        [TestCase(10.0, 10.0, 10.0, -10.0, TestName = "Тест конструктора с" +
                                                      " отрицательным" +
                                                      " значением" +
                                                      " времени")]
        public void OMovementNegativeTest(double amplitude, double frequency,
            double phase, double time)
        {
            Assert.Throws<ArgumentException>(()
                => new OscillatingMovement(amplitude, frequency, phase,
                time));
        }

    }
}
