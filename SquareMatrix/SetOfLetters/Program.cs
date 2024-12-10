using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class LetterSet
{
    static List<char> GetMinimumLetterSet(string filePath)
    {
        var letterFrequency = new Dictionary<char, int>();

        try
        {
            foreach (var line in File.ReadAllLines(filePath))
            {
                var word = line.Trim().ToLower();

                var wordLetterCounts = new Dictionary<char, int>();

                foreach (var letter in word)
                {
                    if (!char.IsLetter(letter))
                        continue;

                    if (wordLetterCounts.ContainsKey(letter))
                        wordLetterCounts[letter]++;
                    else
                        wordLetterCounts[letter] = 1;
                }

                foreach (var kvp in wordLetterCounts)
                {
                    if (letterFrequency.ContainsKey(kvp.Key))
                        letterFrequency[kvp.Key] = Math.Max(letterFrequency[kvp.Key], kvp.Value);
                    else
                        letterFrequency[kvp.Key] = kvp.Value;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
            return new List<char>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return new List<char>();
        }

        var result = new List<char>();
        foreach (var kvp in letterFrequency)
        {
            result.AddRange(Enumerable.Repeat(kvp.Key, kvp.Value));
        }

        result.Sort();
        return result;
    }

    static void Main()
    {
        Console.Write("Enter the path to the file: ");
        string filePath = Console.ReadLine();

        var letters = GetMinimumLetterSet(filePath);

        if (letters.Count > 0)
        {
            Console.WriteLine("Minimum set of letters:");
            Console.WriteLine(string.Join(",", letters));
        }
    }
}
