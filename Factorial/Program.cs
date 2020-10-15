using System;
using System.Threading;

namespace Factorial
{
    internal class Program
    {
        static ulong DefineFact(ulong num)                                                              //определение факториала
        {
            ulong fact = 1;
            for (var i = num; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    public static int ResLength(ulong res)                                                              //нахождение длины значения факториала
        {
            string ResLength = Convert.ToString(res);
            int length = ResLength.Length - 1;
            
            return length;
        }
        public static void PrintRam(char beginCh, char centerCh, char endCh, ulong res)                 //вывод строки рамки без значения
        {
            
            Console.Write(beginCh);

            for (int i = 0; i <= (ResLength(res) + 4); i++)
            {
                Console.Write(centerCh);
            }

            Console.WriteLine(endCh);
        } 
        public static void PrintRamAndValue(char beginCh, char centerCh, char endCh, ulong res)         //вывод строки рамки со значением
        {
            Console.Write(beginCh);
            
            Console.Write($"  {res}  ");
            
            Console.WriteLine(endCh);
        } 

        public static void Output(ulong res)                                                            //вывод рамки полностью
        {
            Console.SetCursorPosition(80, 4);
            PrintRam('╔', '═', '╗', res);

            Console.SetCursorPosition(80, 5);
            PrintRam('║', ' ', '║', res);

            Console.SetCursorPosition(80, 6);
            PrintRamAndValue('║', ' ', '║', res);

            Console.SetCursorPosition(80, 7);
            PrintRam('║', ' ', '║', res);

            Console.SetCursorPosition(80, 8);
            PrintRam('╚', '═', '╝', res);
        }
    public static ulong Read()                                                                          //проверка ввода
        {
            bool isSuccess;
            ulong number;

            do
            {
                isSuccess = ulong.TryParse(Console.ReadLine(), out number);
                Console.WriteLine("Введите число!");
            } while (!isSuccess);
            return number;
        }
        public static void Colors(ulong res)                                                            //изменение цветов
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                
                Output(res);
                
                Thread.Sleep(400);
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                
                Output(res);
                
                Thread.Sleep(400);
                Console.Clear();
                
                Console.ResetColor();
            }
        }
        
    public static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для нахождения его факториала");
            
            ulong res = Read();
            Colors(DefineFact(res));
        }
    }
}
