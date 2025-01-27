using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    class Program
    {
        static char FirstNonRepeated(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                bool isRepeated = false;

                for(int j = 0; j < text.Length; j++)
                {
                    if(i != j && text[j] == current)
                    {
                        isRepeated = true;
                        break;
                    }
                }

                if (!isRepeated)
                {
                    return current;
                }
            }

            return (char)10;
        }

        static string StringCompression(string text)
        {
            string result = "";
            int count = 1;

            for(int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    count++;
                }
                else
                {
                    result += count > 1 ? count.ToString() + text[i - 1].ToString() : text[i - 1].ToString();
                    count = 1;
                }
            }

            result += count > 1 ? count.ToString() + text[text.Length - 1] : text[text.Length - 1].ToString();
            return result;
        }

        static bool MissingNumber(int[] array, out int missing)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            missing = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] + 1 != array[i + 1])
                {
                    missing = array[i] + 1;
                    return true;
                }
            }
            return false;
        }
        static void Main()
        {
            char repeated = FirstNonRepeated("simona is one ame");
            Console.WriteLine(repeated);

            Console.WriteLine(StringCompression("successss"));

            int[] array = { 3, 5, 4, 6, 8 };
            bool missing = MissingNumber(array, out int miss);

            Console.WriteLine(missing + " " + miss);
        }
    }
}
