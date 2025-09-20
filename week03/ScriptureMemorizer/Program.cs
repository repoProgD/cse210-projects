// Enhancementes: In Scripture.HideRandomWords, I added a feature to hide only non-hidden words.


using System;


Reference reference = new Reference("James", 1, 5);
string text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
Scripture scripture1 = new Scripture(reference, text);

while (true)
{
    //Including the reference and the text.
    Console.WriteLine(scripture1.GetDisplayText());


    // Prompt the user to press the enter key or type "quit".
    Console.WriteLine("Please, press enter to continue or type 'quit'");
    string currentInput = Console.ReadLine();

    if (currentInput.ToLower() == "quit")
    {
        break; // break the loop
    }

    if (currentInput == "")
    {
        Console.Clear();
        scripture1.HideRandomWords(5);
    }

    if (scripture1.IsCompletelyHidden())
    {

       // Console.WriteLine("Shutting down the program, all words are hidden.");
        break;
    }

}

Console.Clear();
Console.WriteLine(scripture1.GetDisplayText());
