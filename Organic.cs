using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace template_csharp_virtual_pet
{
    public class Organic : Pet
    {
        private bool organic;

        public bool Organic1 { get; set; }
        public Organic(string name, string species, int hunger, int boredom, int health, bool organic) : base(name, species, hunger, boredom, health, false)
        {
            Organic1 = organic;

        }

        public override void Feed()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} has been fed and lost 20 hunger!");
            Random random = new Random();
            Console.Beep(2637, 100);
            Console.Beep(3135, 100);
            Console.Beep(5274, 100);
            Console.Beep(4186, 100);
            Console.Beep(4698, 100);
            Console.Beep(6271, 100);

            Hunger = Hunger - 20;
            Console.WriteLine();
       


        }

        public override void SeeDoctor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} has gone to see the doctor and gained 30 health");
            Health = Health + 30;
            Console.WriteLine();
        }
        public override void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} has gone outside to play and gained ten hunger, lost 20 boredom and gained 10 health!");
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
            Console.WriteLine();
        }



        public override void GetStatus()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Organic Pet Name:" + Name);
            Console.WriteLine("Organic Pet Species:" + Species);
            Console.WriteLine("Organic Pet Hunger:" + Hunger);
            Console.WriteLine("Organic Pet Health:" + Health);
            Console.WriteLine("Organic Pet Boredom:" + Boredom);
            Console.WriteLine("-------------------------------------------------");


            if (Health <= 30)
            {
                Console.WriteLine($"{Name}: need to see a doctor!\n");
            }
            if (Hunger >= 30)
            {
                Console.WriteLine($"{Name}: I am hungry!\n");

            }
            if (Boredom >= 30)
            {
                Console.WriteLine($"{Name}: I AM BORED!\n");
            }
        }
        public override void Tick()
        {
            Hunger = Hunger + 5;
            Health = Health - 5;
            Boredom = Boredom - 5;
        }
    

        public override void Speak()
        {
            Random random = new Random();


            Console.Beep((random.Next(110, 130)), random.Next(500, 1000));
            Console.Beep((random.Next(110, 130)), random.Next(500, 1000));





        }


    }

}

