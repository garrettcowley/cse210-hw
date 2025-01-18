// To be more creative on this project, I made it so that each entry saves the prompt so that when an entry is loaded it shows the date, prompt and the body of the text. I had to learn about access modifiers to be able to pull that off which was harder than I thought.

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();
        PromptGenerator promptGenerator = new PromptGenerator();

        int selection = 0;
        while (selection != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please type the number of the option you would like: ");
            string input = Console.ReadLine();
            selection = int.Parse(input);
            Console.WriteLine("");

            if (selection == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Write your entry: ");
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, entryText);
                entries.Add(newEntry);
            }
            if (selection == 2)
            {
                foreach (var entry in entries)
                {
                    entry.Display();
                }
            }
            if (selection == 3)
            {
                Console.Write("Enter the file name to load: ");
                string fileName = Console.ReadLine();
                entries.Clear();
                string[] lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        entries.Add(entry);
                    }
                }
            }
            if (selection == 4)
            {
                Console.Write("Enter the file name to save: ");
                string fileName = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                    }
                }
                Console.WriteLine("Entries saved successfully.");
            }
            if (selection == 5)
            {
                Console.WriteLine("Have a great day!");
            }
        }
    }
}
