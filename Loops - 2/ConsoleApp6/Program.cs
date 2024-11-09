using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*Потребителят въвежда последователност от символи,
            ако символът е четна цифра, нейната стойност се 
            добавя към сума на четни цифри, а ако е нечетна,
            нейната стойност се добавя към сумата на нечетните 
            цифри. Въвеждането на символи продължава до натискането 
            на клавиш Еscape, чийто код е 27. Отпечтват се двете
            суми*/

            
            int oddSum = 0;
            int evenSum = 0;
            char ch = ' ';
            while (ch != 27)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                ch = key.KeyChar;
                if(ch >= '0' && ch <= '9')
                {
                    int digit = ch - '0';
                    if(digit % 2 == 0)
                        evenSum+=digit;
                    else
                        oddSum+=digit;
                }
            }

            Console.WriteLine($"\nSum of even digits is {evenSum}");
            Console.WriteLine($"Sum of odd digits is {oddSum}");


            Console.WriteLine("This is the end of my app");

            

            /*Потребителят въвежда последователност от символи,
             *приложението определя от колко символа се състои
             *най-дългата последователност от еднакви символи.
             *За край на последователността от символи се приема 
             *натискането на клавиш Еscape, чийто код е 27
             * Пример : abaabbbcccca - резултат 4 */

            Console.WriteLine("Въведете последователност от символи");
            int currentSeqCount = 1;
            int longestSeqCount = 1;
          
            char currentChar = Console.ReadKey().KeyChar;
            char longestChar = currentChar;
            while (currentChar != 27)
            {
                char previousChar = currentChar;
                currentChar = Console.ReadKey().KeyChar;
                if (previousChar == currentChar)
                {
                    currentSeqCount++;
                    if (currentSeqCount > longestSeqCount)
                    {
                        longestSeqCount = currentSeqCount;
                        longestChar = currentChar;
                    }
                }
                else
                {
                    currentSeqCount = 1;
                }


            }

            Console.WriteLine($"\nLongest sequence is {longestSeqCount} of {longestChar} symbol");
            

            /*Отпечатайте на екрана следната последователност от символи,
             използвайки оператори за цикъл
             
             ****1
             ***22
             **333
             *4444
             55555

            */

            int n = 5;
            for(int i = 1; i<=n; i++)
            {
                for(int k = 1; k <= n - i; k++ )
                    Console.Write('*');
                for(int k = 1; k <= i; k++ )
                    Console.Write(i);
                Console.WriteLine();


            }



            Console.ReadKey();

        }
    }
}
