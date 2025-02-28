﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___7
{
    internal class Program
    {
        static int[] ReadArrayFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] elements = lines[0].Split(',');
            int[] result = new int[elements.Length];

            for(int i = 0; i < elements.Length; i++)
            {
                result[i] = int.Parse(elements[i]);
            }

            return result;
        }

        static int SecondHighest(int[] array)
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

            if (array[array.Length - 2] < array[array.Length - 1])
            {
                return array[array.Length - 2];
            }

            return array[array.Length - 1];
        }

        static void PrintMissingRanges(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            int start = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > start) 
                {
                    PrintRange(start, array[i] - 1); 
                }
                start = array[i] + 1; 
            }

            if (start <= 100) 
            {
                PrintRange(start, 100);
            }
        }

        static void PrintRange(int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(start); 
            }
            else
            {
                Console.WriteLine($"{start}->{end}"); 
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\simon\\OneDrive\\Desktop\\Intro-To-Programming-CSharp\\TasksForExam\\Exam - 7\\Exam - 7\\array.txt";

            int[] array = ReadArrayFromFile(path);
            Console.WriteLine(string.Join(" ", array));

            Console.WriteLine(SecondHighest(array));

            PrintMissingRanges(array);
        }
    }
}
