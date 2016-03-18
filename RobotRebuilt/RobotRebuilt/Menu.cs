using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class Menu
    {
        public void MenuRobot()
        {
             Console.WriteLine("Welcome to the World Wide Robot Foundation!");
            Console.WriteLine("Please choose your choice of robot.");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. American Robot");
            Console.WriteLine("2. Japanese Robot");
            Console.WriteLine("3. African Robot");
            Console.WriteLine("4. Russian Robot");

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                AmericanRobot Robbie = new AmericanRobot("Robbie", "Apple", 100);
                Console.WriteLine("Hello I'm Robbie!. Nice to meet you!");
                Robbie.americanGunShots();
            }
            else if (choice == 2)
            {
                JapaneseRobot Wallie = new JapaneseRobot("Wallie", "Sony", 100);
                Console.WriteLine("Konnichiwa! I am Wallie! Nice to meet you!");
                Wallie.japaneseScreaming();
            }
            else if (choice == 3)
            {
                AfricanRobot Dodger = new AfricanRobot("Dodger", "Samsung", 100);
                Console.WriteLine("Hey there! I am Dodger! Nice to meet you!");
                Dodger.africanJumping();
            }
            else if (choice == 4)
            {
                RussianRobot Charlie = new RussianRobot("Charlie", "Toshiba", 100);
                Console.WriteLine("HEY YOU THERE! I'm Charlie! Nice to meet you!");
                Charlie.russianWaving();
            }
            else
            {
                Console.WriteLine("Sorry I don't recognize that command");
            }
        }

    }
}
