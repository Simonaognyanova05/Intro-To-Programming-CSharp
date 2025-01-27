using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    class Program
    {
        static char FirstNonRepeated(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                bool isRepeated = false;

                for (int j = 0; j < text.Length; j++)
                {
                    if (i != j && text[j] == current)
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
            if (text == null || text.Length == 0)
            {
                return text;
            }

            string result = "";
            int count = 1;  

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])  
                {
                    count++; 
                }
                else
                {
                    result += count > 1 ? count.ToString() + text[i - 1] : text[i - 1].ToString();
                    count = 1;  
                }
            }

            result += count > 1 ? count.ToString() + text[text.Length - 1] : text[text.Length - 1].ToString();

            return result;
        }

        static bool MissingNumber(int[] arr, out int missingNumber)
        {
            missingNumber = -1;

            if (arr == null || arr.Length == 0)
                return false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int i = arr[0]; i < arr[arr.Length - 1]; i++)
            {
                bool found = false;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    missingNumber = i;
                    return true;
                }
            }

            return false;
        }


        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(FirstNonRepeated("the sick brown fox jumps over the lazy dog"));

            Console.WriteLine(StringCompression("successss"));
        }
    }
}
