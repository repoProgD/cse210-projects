using System;

class Program
{
    static void Main(string[] args)
    {
        /* BreathingActivity breathing1 = new BreathingActivity();
         ReflectionActivity reflection1 = new ReflectionActivity();
         ListingActivity listing1 = new ListingActivity();

         breathing1.Run();
         listing1.Run();
         reflection1.Run();*/

        //  menu
        while (true){

            Console.Clear();
            Console.WriteLine("\n*****  Welcome to the Mindfulness App  *****\n");
            Console.WriteLine("Please select an activity from the following: ");
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflecting Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("4) Exit");
            Console.WriteLine("\nPlease enter your choice");

            string pick = Console.ReadLine();

            if (pick == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if (pick == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (pick == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            // finish
            else if (pick == "4")
            {
                Console.WriteLine("\n You have finished your activities. Press any key to quit.");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("Please select a valid choice from 1 to 4. Press any key to go back to the menu.");
                Console.ReadKey();
            }
            


            

        }

       
    }
}