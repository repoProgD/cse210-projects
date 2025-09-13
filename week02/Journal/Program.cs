/* 
Enhancements: I added the ability to prompt a warning if the user tries to quit without saving.
*/

using System;
using System.IO; //StreamWriter uses this module

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool executing = true;
        bool saved = false;

        while (executing)
        {
            Console.WriteLine("Select one of the choices below:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load your journal from a file");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("\nPrompt: " + prompt);
                Console.WriteLine("What's your answer?: ");
                string answer = Console.ReadLine();

                Entry newEntry = new Entry()
                {
                    _date = DateTime.Now.ToShortDateString(), // format the date
                    _promptText = prompt,
                    _entryText = answer
                };

                myJournal.addEntry(newEntry);
                Console.WriteLine("Your entry has been added.\n");
            }

            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                myJournal.SaveToFile(myJournal._entries);
            }

            else if (choice == "4")
            {
                myJournal.LoadFromFile();
            }

            else if (choice == "5")
            {
                if (saved == false)
                {
                    Console.WriteLine("Do you want to save your progress before quitting? (y/n)");
                    string saveChoice = Console.ReadLine();
                    if (saveChoice.ToLower() == "y")
                    {
                        myJournal.SaveToFile(myJournal._entries);
                        saved = true;
                    } 
                }
                executing = false;
                Console.WriteLine("Shutting down the program");
            }
        }
    }
}