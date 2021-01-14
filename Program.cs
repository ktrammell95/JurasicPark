using System;
using System.Collections.Generic;

namespace JurasicPark
{

    class Program
    {
        static void Main(string[] args)
        {

            // - Create a MENU:

            //   - VIEW
            //   - ADD
            //   - REMOVE
            //   - TRANSFER
            //   - SUMMARY
            //   - QUIT

            Console.WriteLine("VIEW");
            Console.WriteLine("ADD");
            Console.WriteLine("REMOVE");
            Console.WriteLine("TRANSFER");
            Console.WriteLine("SUMMARY");
            Console.WriteLine("QUIT");
            // - When user SELECTS an option from the Menu: (If Statement?)
            //   - VIEW:
            //     - Show the all the dinosaurs in the list, ordered by WhenAcquired
            //     - If there aren't any dinosaurs in the park then print out a message that there aren't any
            //   - ADD
            //     - Let the user type in the information for a dinosaur and add it to the list.
            //     - Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code
            //   - REMOVE
            //     - Prompt the user for a dinosaur name then find and delete the dinosaur with that name
            //   - TRANSFER
            //     - Prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information
            //   - SUMMARY
            //     - Display the number of carnivores and the number of herbivores
            //   - QUIT
            //     - Stop the program      
        }
    }
}
