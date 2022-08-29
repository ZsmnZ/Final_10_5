using System;
using System.IO;
namespace Final_10_5
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            Num num = new Num();
            while (true)
            {
                try
                {
                    Logger.Event("\nВведите 2 числа для вычисления суммы:");
                    num.Read();
                }
                catch (FormatException)
                {
                    Logger.Error("\nНедопустимое значение");
                }
            }
        }
    }
    public interface ISum
    {
        void Sum()
        {
        }
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    public interface IWorker
    {
        void Work();
    }
    public class Num : ISum
    {
        public double Num1;
        public double Num2;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine(" 1-е число:");
            Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(" 2-е число:");
            Num2 = Convert.ToDouble(Console.ReadLine());

            ISum(Num1, Num2);
        }

        public void ISum(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"\n{num1} + {num2} = {result}");
        }
    }
}