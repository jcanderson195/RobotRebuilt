using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class RussianRobot : Robot
    {
        public RussianRobot(string RobotName, string RobotBrand, int RobotBatteryLevel)
        {

            robotName = RobotName;
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;
        }


        public int russianWaving()
        {
            int wavesAttempted;
            batteryLevel = 100;
            int decreaseBattery = batteryLevel;

            Console.WriteLine("Enter how many waves I should do 0 - 10 ");
            wavesAttempted = Convert.ToInt32(Console.ReadLine());

            if (wavesAttempted == 0)
            {
                Console.WriteLine("There's no one to say hi to!");
                decreaseBattery = batteryLevel;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted <= 3)
            {
                Console.WriteLine("Hey there's "+wavesAttempted+" people. Hi!!!!!");
                decreaseBattery = batteryLevel - wavesAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted <= 6)
            {
                Console.WriteLine("Now we're talking! " + wavesAttempted + " people waved at.");
                decreaseBattery = batteryLevel - wavesAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted <= 9)
            {
                Console.WriteLine("Wow thats a lot of people. ! " + wavesAttempted+ " people waved at.");
                decreaseBattery = batteryLevel - wavesAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted == 10)
            {
                Console.WriteLine("*Arm disconnects*");
                decreaseBattery = batteryLevel - wavesAttempted;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            return decreaseBattery;


        }
    }
}
