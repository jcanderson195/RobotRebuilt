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
            int batteryLevel = 100;
            int decreaseBattery = batteryLevel;

            Console.WriteLine("Enter how many waves I should do 1 - 10 ");
            wavesAttempted = Convert.ToInt32(Console.ReadLine());

            if (wavesAttempted == 0)
            {
                Console.WriteLine("There's no one to say hi to!");
                decreaseBattery = batteryLevel;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted >= 1)
            {
                Console.WriteLine("Hey there's some people. Hi!!!!!");
                decreaseBattery = batteryLevel - wavesAttempted;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted >= 4)
            {
                Console.WriteLine("Now we're talking! " + wavesAttempted + " jumps completed");
                decreaseBattery = batteryLevel - wavesAttempted;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (wavesAttempted >= 7)
            {
                Console.WriteLine("Wow thats a lot of people. ! " + wavesAttempted);
                decreaseBattery = batteryLevel - wavesAttempted;
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
