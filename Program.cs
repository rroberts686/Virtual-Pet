// Your Program Code Here

using template_csharp_virtual_pet;
{ }
ConsoleColor foreground = Console.ForegroundColor;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.Black;



Shelter myShelter = new Shelter();


Organic pet1 = new Organic("steve", "Giraffe", 60, 60, 60, false);
Organic pet2 = new Organic("Phil", "Hippo", 60, 60, 60, false);

myShelter.AddNewPet(pet1);
myShelter.AddNewPet(pet2);

Console.WriteLine("Welcome to Virtual Pet!" + "\n" + "Press enter to play!");
Console.ReadKey();

bool running = true;
int i = 0;
while (running)
{



    Console.Clear();
    foreground = ConsoleColor.DarkCyan; 
    Console.WriteLine("Pre turn summary. \n\nPet Statuses: \n");
    myShelter.GetAllPets();
    Console.WriteLine("Press any key to start the next turn");
    Console.ReadKey();

    Console.Clear();
    i++;
    foreground = ConsoleColor.DarkCyan;
    Console.WriteLine("This is turn #" + i + "\n");
    myShelter.TickForShelter();
    Console.WriteLine("---------------------------\nMain Menu:");
    Console.WriteLine("---------------------------\n");
    Console.WriteLine("Please select an option from the below");

    Console.WriteLine("1.) Create a pet (Add pet to shelter)");

    Console.WriteLine("2.) Interact with pet");

    Console.WriteLine("3.) Interact with group");

    Console.WriteLine("4.) Adopt (Remove pet from shelter)");

    Console.WriteLine("5.) Exit Game");

    Console.WriteLine("---------------------------\n");



    string y = (Console.ReadLine());

    switch (y)
    {

        case "1":
            //method to create pet in shelter. 

            Console.Clear();
            myShelter.AddNewPetUser();
            break;



        case "2":
            // method to interact with one individual pet
            Console.Clear();
            Pet selectedPet = myShelter.GetPet();
            selectedPet.GetStatus();
            myShelter.InteractWithOnePet(selectedPet);
            break;

        case "3":
            //method to interact with group 
            Console.Clear();
            myShelter.InteractWithShelter();
            break;

        case "4":
            Console.Clear();
            Pet removedPet = myShelter.GetPet();
            myShelter.RemovePet(removedPet);
            break;

        // method to interact with/ and manage the shelter

        case "5":
            Console.WriteLine("\nThanks for playing, here's your end summary\n---------------------------\n");
            myShelter.GetAllPets();
            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();  
            Console.Clear();
            running = false;
            break; 

    }


}




