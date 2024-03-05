using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> likes = new List<string>();

        Console.WriteLine("Enter the names of people who liked your post (press Enter to finish):");

        while (true)
        {
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
                break;

            likes.Add(name);
        }

        DisplayLikes(likes);
    }

    static void DisplayLikes(List<string> likes)
    {
        int count = likes.Count;

        if (count == 0)
        {
            Console.WriteLine("No one likes your post.");
        }
        else if (count == 1)
        {
            Console.WriteLine($"{likes[0]} likes your post.");
        }
        else if (count == 2)
        {
            Console.WriteLine($"{likes[0]} and {likes[1]} like your post.");
        }
        else
        {
            Console.WriteLine($"{likes[0]}, {likes[1]} and {count - 2} others like your post.");
        }
    }
}
