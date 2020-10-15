using System;
using System.Threading;
using System.Diagnostics;

namespace Factorial
{
    internal class Program
    {
        static ulong DefineFact(ulong num)
        {
            ulong fact = 1;
            for (var i = num; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
        public static int ResLength(ulong res)
        {
            string ResLength = Convert.ToString(res);
            int length = ResLength.Length - 1;
            
            return length;
        }
        public static void PrintRam(char beginCh, char centerCh, char endCh, ulong res)
        {
            
            Console.Write(beginCh);

            for (int i = 0; i <= (ResLength(res) + 4); i++)
            {
                Console.Write(centerCh);
            }

            Console.WriteLine(endCh);
        }
        public static void PrintRamAndValue(char beginCh, char centerCh, char endCh, ulong res)
        {
            Console.Write(beginCh);
            
            Console.Write($"  {res}  ");
            
            Console.WriteLine(endCh);
        }

        public static void Output()
        {
            ulong res = DefineFact(Convert.ToUInt64(Console.ReadLine()));
            
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
        static bool Check(ulong number)
        {
            var strNumber = Convert.ToString(number);
            bool check = ulong.TryParse(strNumber, out number);
            
            return check;
        }
        public static void Colors()
        {
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                
                Output();
                Thread.Sleep(100);
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                
                Output();
                Thread.Sleep(100);
                Console.ResetColor();
            }
        }
        
    public static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для нахождения его факториала");
            ulong res = DefineFact(Convert.ToUInt64(Console.ReadLine()));
            
            if (Check(res) == false)
            {
                Console.WriteLine("Введите число!");
                res = DefineFact(Convert.ToUInt64(Console.ReadLine()));            
            }
            else 
            //Output();
            
            Colors();
        }
    }
}