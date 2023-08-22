using Microsoft.VisualBasic;

namespace template_csharp_virtual_pet
{
    public abstract class Pet
    {
        //fields
        private string name;
        private string species;
        private int hunger;
        private int boredom;
        private int health;
        private bool isRobot;



        // properties
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public bool IsRobot { get; set; }
        //constructor

        public Pet(string name, string species, int hunger, int boredom, int health, bool isRobot)
        {
            Name = name;
            Species = species;
            Hunger = hunger;
            Boredom = boredom;
            Health = health;
            IsRobot = isRobot;
        }
        public abstract void Feed();





        public abstract void SeeDoctor();



        public abstract void Play();



        public abstract void GetStatus();



        public abstract void Tick();


        public abstract void Speak();



        }

    }



