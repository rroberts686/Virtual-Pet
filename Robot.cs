using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{

    public class Robot : Pet
    {
        private bool robot;

        public bool Robot1 { get; set; }
        public Robot(string name, string species, int hunger, int boredom, int health, bool robot) : base(name, species, hunger, boredom, health, robot)
        {
            Robot1 = robot;


        }

        public override void Feed()

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} has been given 30 Energy");
            Console.Beep(2637, 100);
            Console.Beep(3135, 100);
            Console.Beep(5274, 100);
            Console.Beep(4186, 100);
            Console.Beep(4698, 100);
            Console.Beep(6271, 100);
            Hunger = Hunger - 30;

            Console.WriteLine();
        }



        public override void SeeDoctor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Taking {Name} to the mechanic has given them 25 Health\n");
            Health = Health + 25;
           
        }

        public override void Play()

        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine($"Giving {Name} some new tasks has given them 30 stimulation and increased their health by 20\n");
            Boredom = Boredom + 30;
            Health = Health + 20;
            
        }

        public override void GetStatus()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pet is a robot");
            Console.WriteLine("Robot Pet Name:" + Name);
            Console.WriteLine("Robot is made out of" + Species);
            Console.WriteLine("Robot Energy:" + Hunger);
            Console.WriteLine("Robot Health:" + Health);
            Console.WriteLine("Robot Stimulation level:" + Boredom);
            Console.WriteLine("-------------------------------------------------");

            if (Health <= 30)
            {
                Console.WriteLine($"{Name}: Beep Boop, I need to see a mechanic!\n");
            }
            if (Hunger >= 30)
            {
                Console.WriteLine($"{Name}:Beepity boop beep I need energy!\n");

            }
            if (Boredom >= 30)
            {
                Console.WriteLine($"{Name}: I am bored, beep\n");
            }
        }



        public override void Tick()
        {
            Hunger = Hunger + 20;
            Health = Health + 10;
            Boredom = Boredom - 10;

        }

        public override void Speak()
        {
            Random random = new Random();
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));
            Console.Beep((random.Next(38, 7000)), random.Next(38, 150));


        }

    }
}


