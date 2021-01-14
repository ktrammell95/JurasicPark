# JurasicPark

## PEDA

### Problem

Need a list of Dinosaurs:

- Name
- Diet Type
- When Acquired
- Weight
- Enclosure Number

Need to be able to track:

- When a dinosaur came in
- What enclosure they are in at given time

Need to DESCRIPTION of each dinosaur to include all the properties

Need to be able to:

- VIEW - View a list of dinosaurs
- ADD - Add a new dinosaur
- REMOVE - Remove a dinosaur from the list
- TRANSFER - Move a dinosaur from one enclosure to another
- SUMMARY - Display the number of carnivores and the number of herbivores
- QUIT - This will stop the program

### Examples

Dinosaurs:

| Name | Diet Type | WhenAcquired | Weight | Enclosure Number |

---

| Tyrannosaurus Rex | Carnivore | 1/19/2020 | 15000 | 1 |  
| Triceratops | Herbivore | 12/1/2020 | 24000 | 2 |
| Velociraptor | Carnivore | 1/1/2021 | 15 | 3 |
| Stegosaurus | Herbivore | 1/5/2021 | 6800 | 4 |
| Spinosaurus | Carnivore | 5/10/2020 | 8818 | 5 |
| Archaeopteryx | Carnivore | 3/13/2020 | 2 | 6 |
| Brachiosaurus | Herbivore | 9/15/2020 | 124000 | 7 |
| Allosaurus | Carnivore | 6/1/2020 | 4409 | 8 |
| Apatosaurus | Herbivore | 8/1/2020 | 90000 | 9 |
| Dilophosaurus | Carnivore | 2/12/2020 | 661 | 10 |

### Data

- Name (string)
- Diet Type (string)
- When Acquired (Date, string)
- Weight (string)
- Enclosure Number (int)

### Algorithm

- Create a LIST of dinosaurs (Class)

- Create a MENU:

  - VIEW
  - ADD
  - REMOVE
  - TRANSFER
  - SUMMARY
  - QUIT

- When user SELECTS an option from the Menu: (If Statement?)
  - VIEW:
    - Show the all the dinosaurs in the list, ordered by WhenAcquired
    - If there aren't any dinosaurs in the park then print out a message that there aren't any
  - ADD
    - Let the user type in the information for a dinosaur and add it to the list.
    - Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code
  - REMOVE
    - Prompt the user for a dinosaur name then find and delete the dinosaur with that name
  - TRANSFER
    - Prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information
  - SUMMARY
    - Display the number of carnivores and the number of herbivores
  - QUIT
    - Stop the program
