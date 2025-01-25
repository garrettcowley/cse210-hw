//The program only hides words that have not been hidden. That was hard to pull off.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 32, 20, 21);

        Scripture scripture = new Scripture(reference, "20 Now of this thing ye must judge. Behold, I say unto you, that it is on the one hand even as it is on the other; and it shall be unto every man according to his work. 21 And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Good job! You've memorized the scripture!");
                break;
            }
            Console.WriteLine("Press Enter continue or type 'quit'");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(1);
        }
    }
}
