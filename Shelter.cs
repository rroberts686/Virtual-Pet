using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        //field

        private List<Pet> shelterList;


        //propety

        public List<Pet> ShelterList { get; set; }

        public Shelter()
        {
            ShelterList = new List<Pet>();
        }

        public void GetAllPets()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int x = 0;
            foreach (Pet pet in ShelterList)
            {
                if (pet.IsRobot == false)
                //need to add this in 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Pet ID: {x++} \nPet Name:" + pet.Name);
                    Console.WriteLine("Pet Species:" + pet.Species);
                    Console.WriteLine("Pet Hunger:" + pet.Hunger);
                    Console.WriteLine("Pet Health:" + pet.Health);
                    Console.WriteLine("Pet Boredom:" + pet.Boredom + "\n ------------------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan; 
                }
                if (pet.IsRobot == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine($"Robot ID: {x++} \nRobot Name:" + pet.Name);
                    Console.WriteLine("Robot Material:" + pet.Species);
                    Console.WriteLine("Robot Energy:" + pet.Hunger);
                    Console.WriteLine("Robot Health:" + pet.Health);
                    Console.WriteLine("Robot Stimulation Level:" + pet.Boredom + "\n ------------------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan; 
                }

            }

            Console.ReadKey(); 

        }



        public void AddNewPet(Pet pet)
        {

            ShelterList.Add(pet);
        }

        public void RemovePet(Pet pet)
        {



            ShelterList.Remove(pet);
            if (pet.IsRobot == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{pet.Name} has been adopted!");
                Console.ReadLine();
            }

            if (pet.IsRobot == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{pet.Name} has been adopted!");
                Console.ReadLine();
            }


        }

        public void AddNewPetUser()
        {
            Console.WriteLine("Is your pet a robot?");
            string y = Console.ReadLine().ToLower();

            if (y == "yes")
            {
                Robot robot = new Robot("", "", 0, 0, 0, true);
                Console.WriteLine("\nWhat would you like your robot's name to be?\n");
                robot.Name = Console.ReadLine();
                Console.WriteLine("\nWhat material is your robot made of?\n");
               

                robot.Species = Console.ReadLine();
                robot.Health = 100;
                robot.Hunger = 100;
                robot.Boredom = 50;
                ShelterList.Add(robot);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"-------------------------------------------------\n{robot.Name} has been created! \n-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkCyan; 
                Console.WriteLine("\nPress any key to return to the main console!");
                Console.ReadKey();

            }

            if (y == "no")
            {
                Organic organic = new Organic("", "", 0, 0, 0, false);
                Console.WriteLine("\nWhat would you like your pets name to be?\n");
                organic.Name = Console.ReadLine();
                Console.WriteLine("\nWhat species is your pet?\n");
                organic.Species = Console.ReadLine();
                organic.Health = 60;
                organic.Hunger = 60;
                organic.Boredom = 60;
                ShelterList.Add(organic);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"-------------------------------------------------\n{organic.Name} has been created!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nPress any key to return to the main console!");
                Console.ReadKey();
            }

            else

            { Console.WriteLine("Invalid entry"); }
        }



        public void ShelterStatus()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Pet pet in ShelterList)
            {
                pet.GetStatus();
               
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        //play with entire group of pets    
        public void PetGroupPlay()
        {
            Console.WriteLine("\nYou've let the whole shelter out to play.");
            foreach (Pet pet in ShelterList)
            {
                pet.Play();
                Console.WriteLine("\n");
                Console.WriteLine("-------------------------------------");
            }

        }
        //feeds all pets in shelter 
        public void PetGroupFeed()
        {
            Console.WriteLine("\nYou've chosen to feed the whole shelter");
            foreach (Pet pet in ShelterList)
            {
                
                Console.WriteLine("\n");
                pet.Feed();
                Console.WriteLine("-------------------------------------\n");


            }
        }

        //feeds all pets in sheltr 
        public void PetGroupSeeDoctor()
        {
            Console.WriteLine("\nYou've chosen to take the shelter to the doctor/mechanic");

            foreach (Pet pet in ShelterList)
            {
                Console.WriteLine("\n");
                pet.SeeDoctor();
                Console.WriteLine("-------------------------------------\n");

            }
        }



        public Pet GetPet()
        {
            GetAllPets();
            Console.WriteLine("Pick your pet\n");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            if (q <= (ShelterList.Count -1) && q >= 0 )
            {
                return ShelterList[q];

            }
            else
            {
               Console.WriteLine("\nError, that ID is not in the range. Try again \n");
                return GetPet();
            }

        }



    

        public void InteractWithOnePet(Pet pet)
        {

            Console.WriteLine("\nWhat would you like to do? Feed, play or have them see doctor? \n*Bonus: Ask pet to speak*");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine();



            switch (userInput)
            {
                case "feed":
                    pet.Feed();

                    break;

                case "play":
                    pet.Play();
                    break;

                case "doctor":
                    pet.SeeDoctor();
                    break; 

                case "speak":
                    pet.Speak();
                    break;

                default:
                    Console.WriteLine("Please try again");
                    break;

            }

            Console.WriteLine($"\n{pet.Name}'s health is now {pet.Health} \nBoredom is now {pet.Boredom}\n Hunger is now {pet.Hunger} \n\n");
            Console.ReadLine();

        }

        public void InteractWithShelter()
        {
            Console.WriteLine(" \nWould you like to feed the whole shelter, play with the whole shelter or take the whole shelter to the doctor \nType 'Play', 'Feed' or 'Doctor'");
            string groupAnswer = Console.ReadLine().ToLower();

            switch (groupAnswer)
            {
                case "play":
                    PetGroupPlay();
                    Console.ReadLine();
                    break;

                case "feed":
                    PetGroupFeed();
                    Console.ReadLine();
                    break;

                case "doctor":
                    PetGroupSeeDoctor();
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    break;
            }



        }
        public void TickForShelter()
        {
            foreach (Pet pet in ShelterList)
            {
                pet.Tick();
            }

        }

        
        
    }
}





















