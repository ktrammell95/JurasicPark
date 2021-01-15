using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public string WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

    }

    class Program
    {
        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BannerMessage("Welcome to our Dinosaur World");

            // | Tyrannosaurus Rex | Carnivore | 1/19/2020 | 15000 | 1 |
            // | Triceratops | Herbivore | 12/1/2020 | 24000 | 2 |
            // | Velociraptor | Carnivore | 1/1/2021 | 15 | 3 |
            // | Stegosaurus | Herbivore | 1/5/2021 | 6800 | 4 |
            // | Spinosaurus | Carnivore | 5/10/2020 | 8818 | 5 |
            // | Archaeopteryx | Carnivore | 3/13/2020 | 2 | 6 |
            // | Brachiosaurus | Herbivore | 9/15/2020 | 124000 | 7 |
            // | Allosaurus | Carnivore | 6/1/2020 | 4409 | 8 |
            // | Apatosaurus | Herbivore | 8/1/2020 | 90000 | 9 |
            // | Dilophosaurus | Carnivore | 2/12/2020 | 661 | 10 | 

            var dinosaurs = new List<Dinosaur>()
            {
                new Dinosaur()
                {
                    Name = "Tyrannosaurus Rex",
                    DietType = "Carnivore",
                    WhenAcquired = "1/19/2020 ",
                    Weight = 15000,
                    EnclosureNumber = 1,

                },
                new Dinosaur()
                {
                    Name = "Triceratops",
                    DietType = "Herbivore",
                    WhenAcquired = "1/1/2021",
                    Weight = 24000,
                    EnclosureNumber = 2,

                },
                new Dinosaur()
                {
                    Name = "Velociraptor",
                    DietType = "Carnivore",
                    WhenAcquired = "1/1/2021",
                    Weight = 15,
                    EnclosureNumber = 3,

                },
                new Dinosaur()
                {
                    Name = "Stegosaurus",
                    DietType = "Herbivore",
                    WhenAcquired = "1/5/2021",
                    Weight = 6800,
                    EnclosureNumber = 4,

                },
                new Dinosaur()
                {
                    Name = "Spinosaurus",
                    DietType = "Carnivore",
                    WhenAcquired = "5/10/2020",
                    Weight = 8818,
                    EnclosureNumber = 5,

                },
                new Dinosaur()
                {
                    Name = "Archaeopteryx",
                    DietType = "Carnivore",
                    WhenAcquired = "3/13/2020",
                    Weight = 2,
                    EnclosureNumber = 6,

                },
                new Dinosaur()
                {
                    Name = "Brachiosaurus",
                    DietType = "Herbivore",
                    WhenAcquired = "9/15/2020",
                    Weight = 124000,
                    EnclosureNumber = 7,

                },
                new Dinosaur()
                {
                    Name = "Allosaurus",
                    DietType = "Carnivore",
                    WhenAcquired = "6/1/2020",
                    Weight = 4409,
                    EnclosureNumber = 8,

                },
                new Dinosaur()
                {
                    Name = "Apatosaurus",
                    DietType = "Herbivore",
                    WhenAcquired = "8/1/2020 ",
                    Weight = 90000,
                    EnclosureNumber = 9,

                },
                new Dinosaur()
                {
                    Name = "Dilophosaurus",
                    DietType = "Carnivore",
                    WhenAcquired = "2/12/2020",
                    Weight = 661,
                    EnclosureNumber = 10,

                },
            };

            var rightNow = DateTime.Now;
            var currentMonth = rightNow.Month;
            var currentDay = rightNow.Day;
            var currentYear = rightNow.Year;

            var userHasChosenToQuit = false;
            //       while our boolean is false
            while (userHasChosenToQuit == false)
            {
                // - Create a MENU:

                //   - VIEW
                //   - ADD
                //   - REMOVE
                //   - TRANSFER
                //   - SUMMARY
                //   - QUIT

                Console.WriteLine("VIEW - View description of dinosaur");
                Console.WriteLine("ADD - Add a new dinosaur");
                Console.WriteLine("REMOVE - Remove a dinosaur from the inventory");
                Console.WriteLine("TRANSFER - Move a dinosaur to a new enclosure");
                Console.WriteLine("SUMMARY - See the number of dinosaurs by diet");
                Console.WriteLine("QUIT - Leave the program");
                Console.WriteLine();

                Console.Write("Make a selection from our menu options: ");
                var selection = Console.ReadLine().ToUpper().Trim();

                if (selection == "VIEW")
                {

                    if (dinosaurs.Count != 0)
                    {
                        foreach (var dinosaur in dinosaurs)
                        {
                            Console.WriteLine($"The {dinosaur.Name} is a {dinosaur.DietType} that weighs {dinosaur.Weight} pounds. {dinosaur.Name} was placed in enclosure {dinosaur.EnclosureNumber} on {dinosaur.WhenAcquired}.");

                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no dinosaurs");
                    }
                    Console.WriteLine("-----------------------");

                }
                else if (selection == "ADD")
                {
                    Console.WriteLine("What is the name of the Dinosaur? ");
                    var newDinosaurName = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Is the Dinosaur a Carnivore or Herbivore? ");
                    var newDinosaurDietType = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("How many pounds does the Dinosaur weigh? ");
                    var newDinosaurWeightString = Console.ReadLine();
                    var newDinosaurWeight = int.Parse(newDinosaurWeightString);
                    Console.WriteLine();

                    // var newDinosaurEnclosureNumberString = "";
                    var newDinosaurEnclosureNumber = 0;
                    if (dinosaurs.Count > 0)
                    {
                        newDinosaurEnclosureNumber = (dinosaurs.Count + 1);
                    }
                    else
                    {
                        Console.WriteLine("What enclosure will the Dinosaur be in? ");
                        var newDinosaurEnclosureString = Console.ReadLine();
                        var newDinosaurEnclosure = int.Parse(newDinosaurEnclosureString);
                        newDinosaurEnclosureNumber = newDinosaurEnclosure;
                    }

                    var newDinosaur = new Dinosaur()
                    {
                        Name = newDinosaurName,
                        DietType = newDinosaurDietType,
                        WhenAcquired = $"{currentMonth}/{currentDay}/{currentYear}",
                        Weight = newDinosaurWeight,
                        EnclosureNumber = newDinosaurEnclosureNumber,
                    };

                    dinosaurs.Add(newDinosaur);
                    Console.WriteLine("-----------------------");

                }
                else if (selection == "REMOVE")
                {
                    Console.WriteLine("What Dinosaur would you like to remove? ");
                    var dinosaurRemoveInput = Console.ReadLine();

                    var dinosaurToRemove = dinosaurs.Find(dinosaur => dinosaur.Name == dinosaurRemoveInput);
                    dinosaurs.Remove(dinosaurToRemove);
                    Console.WriteLine("-----------------------");

                }
                else if (selection == "TRANSFER")
                {
                    Console.WriteLine("What Dinosaur would you like to move to a new enclosure? ");
                    var dinosaurMoveInput = Console.ReadLine();

                    var dinosaurToMove = dinosaurs.Find(dinosaur => dinosaur.Name == dinosaurMoveInput);

                    Console.WriteLine("What is the new enclosure number? ");
                    var dinosaurNewEnclosure = Console.ReadLine();
                    var newDinosaurEnclosure = int.Parse(dinosaurNewEnclosure);
                    dinosaurToMove.EnclosureNumber = (newDinosaurEnclosure);
                    Console.WriteLine("-----------------------");

                }
                else if (selection == "SUMMARY")
                {
                    var findCarnivores = dinosaurs.Count(dinosaur => dinosaur.DietType == "Carnivore");
                    var findHerbivores = dinosaurs.Count(dinosaur => dinosaur.DietType == "Herbivore");

                    Console.WriteLine($" There are {findHerbivores} Herbivores and {findCarnivores} Carnivores in the park");
                    Console.WriteLine("-----------------------");

                }
                else if (selection == "QUIT")
                {
                    userHasChosenToQuit = true;
                    BannerMessage("Thanks for stopping by!");

                }
            }
        }
    }
}