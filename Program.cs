using System;
using System.ComponentModel;
using System.Linq;

namespace Text1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a couple of numbers separated by a hyphen.");
        string input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input))
            Environment.Exit(0);
        List<int> numbers = input.Split('-').Select(int.Parse).ToList();
        int identifier = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            identifier = numbers[i];
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[j] == identifier)
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }
        }

        //4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.
        //For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        Console.WriteLine("Enter some words for a new variable.");
        string input4 = Console.ReadLine();
        string newPascalVariable = CreatePascalVariable(input4);
        Console.WriteLine(newPascalVariable);
        //5 - Write a program and ask the user to enter an English word.
        //Count the number of vowels(a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.
        Console.WriteLine("Enter 1 English word.");
        string englishWord = Console.ReadLine();
        int vowelCount = CountVowels(englishWord);
        Console.WriteLine($"The count of vowels in the word entered is: {vowelCount}");
    }

    public static string CreatePascalVariable(string input)
    {
        string[] words = input.Split(' ', '-', '.');
        List<string> newVariable = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            newVariable.Add((words[i])[0].ToString().ToUpper());
            for (int j = 1; j < words[i].Length; j++)
            {
                newVariable.Add((words[i])[j].ToString().ToLower());
            }
        }
        return  String.Join("", newVariable);
    }

    public static int CountVowels(string word)
    {
        int count = 0;
        char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
        foreach (var letter in word)
        {
            foreach (var vowel in vowels)
            {
                if (letter == vowel)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
