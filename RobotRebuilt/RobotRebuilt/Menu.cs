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
                Console.WriteLine("1. American Robot (will interact with another robot)");
                Console.WriteLine("2. Japanese Robot");
                Console.WriteLine("3. African Robot");
                Console.WriteLine("4. Russian Robot");
                Console.WriteLine("5. Exit");

                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    AmericanRobot newAmerican = new AmericanRobot("Robbie", "Apple", 100);
                    Console.WriteLine("Hello I'm Robbie!. Nice to meet you!");
                    newAmerican.americanGunShots();
                }
                else if (choice == 2)
                {
                    JapaneseRobot newJapanese = new JapaneseRobot("Wallie", "Sony", 100);
                    Console.WriteLine("Konnichiwa! I am Wallie! Nice to meet you!");
                    newJapanese.japaneseScreaming();
                }
                else if (choice == 3)
                {
                    AfricanRobot newAfrican = new AfricanRobot("Dodger", "Samsung", 100);
                    Console.WriteLine("Hey there! I am Dodger! Nice to meet you!");
                    newAfrican.africanJumping();
                }
                else if (choice == 4)
                {
                    RussianRobot newRussian = new RussianRobot("Charlie", "Toshiba", 100);
                    Console.WriteLine("HEY YOU THERE! I'm Charlie! Nice to meet you!");
                    newRussian.russianWaving();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Thank you for your time! Have a good day!");
                }
                else
                {
                    Console.WriteLine("Sorry I don't recognize that command");
                    MenuRobot();
                }
            }
        }

    }

