﻿using System;
using IMovement;

namespace UMovement
{
    /// <summary>
    /// Класс, вычисляющий равномерное движение.
    /// </summary>
    public class UniformMovement : InterfaceMovement
    {
        /// <summary>
        /// Поля класса.
        /// </summary>
        private double _speed;
        private double _length;
        private double _startLength;
        private double _time;

        public double Speed
        {
            get { return _speed; }
        }
        public double Time
        {
            get { return _time; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="inputSpeed">Входная скорость</param>
        /// <param name="inputTime">Входное время</param>
        public UniformMovement(double inputSpeed, double inputTime)
        {
            if (inputSpeed < 0)
            {
                throw new ArgumentException("Скорость не может быть меньше" +
                                            " 0.");
            }
            if (inputTime < 0)
            {
                throw new ArgumentException("Время не может быть меньше 0.");
            }
            _speed = inputSpeed;
            _length = 0;
            _startLength = _speed * 1000 / 3600;
            _time = inputTime;
        }

        /// <summary>
        /// Метод, вычисления пройденного расстояния равномерного
        /// движения.
        /// </summary>
        /// <returns>Выходное значение расстояния.</returns>
        public double Calculation()
        {
            for(int i = 0; i < _time; i++)
            {
                _length += _startLength;
            }
            return _length;
        }
    }
}