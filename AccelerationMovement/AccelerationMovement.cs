using System;
using IMovement;

namespace AMovement
{
    /// <summary>
    /// Класс, вычисляющий равноускоренное движение.
    /// </summary>
    public class AccelerationMovement : InterfaceMovement
    {
        /// <summary>
        /// Поля класса.
        /// </summary>
        private double _speed;
        private double _accel;
        private double _length;
        private double _time;

        public double Acceleration
        {
            get { return _accel; }
        }

        public double Time
        {
            get { return _time; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="inputAccel">Входное ускорение</param>
        /// <param name="inputTime">Входное время</param>
        public AccelerationMovement(double inputAccel, double inputTime)
        {
            if (inputAccel < 0)
            {
                throw new ArgumentException("Ускорение не может быть" +
                                            " меньше 0.");
            }
            if (inputTime < 0)
            {
                throw new ArgumentException("Время не может быть меньше" +
                                            " 0.");
            }
            _accel = inputAccel;
            _time = inputTime;
            _speed = 0;
            _length = 0;
        }

        /// <summary>
        /// Метод, вычисляющий пройденное расстояние с равноускоренным
        /// движением.
        /// </summary>
        /// <returns>Выходное значение расстояния.</returns>
        public double Calculation()
        {
            _length = (_accel * Math.Pow(_time, 2) / 2);
            return _length;
        }
    }
}