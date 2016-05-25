using System;
using IMovement;

namespace OMovement
{
    /// <summary>
    /// Класс, вычисляющий координату колебательного движения.
    /// </summary>
    public class OscillatingMovement : InterfaceMovement
    {
        /// <summary>
        /// Поля класса.
        /// </summary>
        private double _frequency;
        private double _amplitude;
        private double _phase;
        private double _time;
        private double _yCord;

        public double Frequency
        {
            get { return _frequency; }
        }

        public double Amplitude
        {
            get { return _amplitude; }
        }

        public double Phase
        {
            get { return _phase; }
        }

        public double Time
        {
            get { return _time; }
        }

        public double FuncValue
        {
            get { return _yCord; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="inputAmplitude">Входная амплитуда</param>
        /// <param name="inputFrequency">Входная частота</param>
        /// <param name="inputPhase">Входная фаза</param>
        /// <param name="inputTime">Входное время (в сек.)</param>
        public OscillatingMovement(double inputAmplitude,
            double inputFrequency, double inputPhase, double inputTime)
        {
            if (inputAmplitude < 0)
            {
                throw new ArgumentException("Амплитуда не может быть" +
                                            " меньше 0.");
            }
            if (inputFrequency < 0)
            {
                throw new ArgumentException("Частота не может быть меньше" +
                                            " 0.");
            }
            if (inputTime < 0)
            {
                throw new ArgumentException("Время не может быть меньше 0.");
            }
            _amplitude = inputAmplitude;
            _frequency = inputFrequency;
            _phase = inputPhase;
            _time = inputTime;
            _yCord = 0;
        }

        /// <summary>
        /// Метод вычисления координаты Y колебательного движения.
        /// </summary>
        /// <returns>Выходное значение Y.</returns>
        public double Calculation()
        {
            _yCord = _amplitude * Math.Cos((_frequency * _time) + _phase);
            return _yCord;
        }
    }
}