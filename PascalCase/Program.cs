using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words separated by a space:");
        string input = Console.ReadLine();

        string pascalCase = ToPascalCase(input);
        
        Console.WriteLine("PascalCase Variable Name: " + pascalCase);
    }

    static string ToPascalCase(string input)
    {
        string[] words = input.ToLower().Split(' ');

        string pascalCase = "";
        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                pascalCase += char.ToUpper(word[0]) + word.Substring(1);
            }
        }

        return pascalCase;
    }
}
