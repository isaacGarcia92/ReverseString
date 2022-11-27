using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter word: ");

        string userWord = Console.ReadLine().ToUpper();

        Console.WriteLine("The new word is: ");

        bool isAPalindrome = true;

        for (int i = 0; i < userWord.Length; i++)
        {
            Console.Write(userWord[userWord.Length - i - 1]);
        }

        for (int i = 0; i < userWord.Length; i++)
        {
            if (userWord[i] != userWord[userWord.Length - i - 1])
            {
                isAPalindrome = false;
            }
        }

        Console.WriteLine();

        if (isAPalindrome)
        {
            Console.WriteLine("This word is a palindrome.");
        }

        else
        {
            Console.WriteLine("This word is not a palindrome.");
        }
    }
}


