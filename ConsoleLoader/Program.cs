using System;
using UMovement;
using AMovement;
using OMovement;

namespace ConsoleLoader
{
    /// <summary>
    /// Главная точка входа приложения.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string select;

            Console.WriteLine("Программа вычисления движения.\n");
            Console.WriteLine("1. Равномерное движение;");
            Console.WriteLine("2. Равноускоренное движение;");
            Console.WriteLine("3. Колебательное движение;");
            Console.WriteLine("0. Выход.\n");
            Console.Write("Введите команду: ");
            select = Console.ReadLine();

            switch (select)
            {
                // Равномерное движение.
                case "1":

                    {
                        double inputSpeed;
                        double inputTime;

                        Console.WriteLine();
                        Console.WriteLine("Выбран расчет равномерного" +
                                          " движения.");
                        do
                        {
                            Console.Write("Введите скорость (в км/ч): ");
                            inputSpeed = Convert.ToDouble(Console.ReadLine());
                            if (inputSpeed <= 0)
                            {
                                Console.WriteLine("Ошибка. Неверно задан" +
                                                  " параметр.");
                            }
                        } while (inputSpeed <= 0);
                        do
                        {
                            Console.Write("Введите время (в сек): ");
                            inputTime = Convert.ToInt32(Console.ReadLine());
                            if (inputTime <= 0)
                            {
                                Console.WriteLine("Ошибка. Неверно задан" +
                                                  " параметр.");
                            }
                        } while (inputTime <= 0);

                        UniformMovement obj = new UniformMovement(inputSpeed,
                            inputTime);

                        Console.WriteLine("Выбрана скорость {0} км/ч." +
                            " и время {1} сек.", inputSpeed, inputTime);
                        Console.WriteLine("\nРезультаты расчета:");

                        Console.WriteLine("Расстояние = {0:##.###} м",
                            obj.Calculation());

                        break;
                    }
                // Равноускоренное движение.
                case "2":
                    {
                        double inputAccel;
                        int inputTime;

                        Console.WriteLine();
                        Console.WriteLine("Выбран расчет равноускоренного" +
                                          " движения.");

                        do
                        {
                            Console.Write("Введите ускорение (в м/с^2): ");
                            inputAccel = Convert.ToDouble(Console.ReadLine());
                            if (inputAccel <= 0)
                            {
                                Console.WriteLine("Ошибка. Неверно задан" +
                                                  " параметр.");
                            }
                        } while (inputAccel <= 0);
                        do
                        {
                            Console.Write("Введите время (в сек): ");
                            inputTime = Convert.ToInt32(Console.ReadLine());
                            if (inputTime <= 0)
                            {
                                Console.WriteLine("Ошибка. Неверно задан" +
                                                  " параметр.");
                            }
                        } while (inputTime <= 0);

                        AccelerationMovement obj =
                            new AccelerationMovement(inputAccel, inputTime);

                        Console.WriteLine("Выбрано ускорение {0} м/с^2." +
                            " и время {1} сек.", inputAccel, inputTime);
                        Console.WriteLine("\nРезультаты расчета:");

                        Console.WriteLine("Растояние = {0:##.###} м",
                            obj.Calculation());

                        break;
                    }
                // Колебательное движение.
                case "3":
                    {
                        double inputAmplitude;
                        double inputFrequency;
                        double inputPhase;
                        int inputTime;

                        Console.WriteLine();
                        Console.WriteLine("Выбран расчет колебательного" +
                                          " движения.");

                        do
                        {
                            Console.Write("Введите значение амплитуды: ");
                            inputAmplitude =
                                Convert.ToDouble(Console.ReadLine());
                            if (inputAmplitude <= 0)
                            {
                                Console.WriteLine("Ошибка. Неверно задан" +
                                                  " параметр.");
                            }
                        } while (inputAmplitude <= 0);

                        do
                        {
                            Console.Write("Введите время (в сек): ");
                            inputTime = Convert.ToInt32(Console.ReadLine());
                            if (inputTime <= 0)
                            {
                                Console.WriteLine("Ошибка. Неверно задан" +
                                                  " параметр.");
                            }
                        } while (inputTime <= 0);

                        Console.Write("Введите значение частоты: ");
                        inputFrequency = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите значение фазы: ");
                        inputPhase = Convert.ToDouble(Console.ReadLine());

                        OscillatingMovement obj = new OscillatingMovement(
                            inputAmplitude, inputFrequency, inputPhase,
                            inputTime);

                        Console.WriteLine("Выбраны следующие параметры:");
                        Console.WriteLine("Амплитуда: {0}\t Частота: {1}\t" +
                                          " Фаза: {2}", inputAmplitude,
                                          inputFrequency, inputPhase,
                                          inputTime);
                        Console.WriteLine("\nРезультаты расчета:");

                        Console.WriteLine("Координата Y = {0}",
                            obj.Calculation());

                        
                        break;
                    }
                // Выход.
                case "0":
                    {
                        Console.WriteLine("Выход из программы.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка.");
                        break;
                    }
            }

            Console.Read();
        }
    }
}