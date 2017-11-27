using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Lesson_4_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
             FirstTask();
            SecondTask();
            Console.ReadLine();


        }

        private static void SecondTask()
        {
            try
            {
                int[] numbers = new int[5];
                int counter = 0;
                for (int i = 0; i <= numbers.Length; i++)
                {
                    numbers[i] = ++counter;
                }
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива");
            }

        }

        private static void FirstTask()
        {
         
            Console.WriteLine("Введите числитель и знаменатель");
           
            double numerator;
            double denominator;
            double.TryParse(Console.ReadLine(), out numerator);
            double.TryParse(Console.ReadLine(), out denominator);
            double answer;
            try
            {
                answer=Divide(numerator, denominator);
                Console.Write("Ответ - ");
                Console.WriteLine(answer);
            }

            catch(ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static double Divide(double numerator,double denominator)
        {
            if (numerator == 0&&denominator==0)
            {
                throw new ArgumentNullException();
            }
            else if (denominator == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return (numerator / denominator);
            }
        }
    }
}
