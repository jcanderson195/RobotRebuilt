using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class AmericanRobot : Robot
    {

        public AmericanRobot(string RobotName, string RobotBrand, int RobotBatteryLevel)
        {
            robotName = RobotName;
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;
        }

        public int americanGunShots()
        {
            int bulletNumber = 100;
            int batteryLevel = 100;

            Console.WriteLine("Enter how many bullets you want to shoot 1 - 100: ");
            bulletNumber = Convert.ToInt32(Console.ReadLine());

            if (bulletNumber == 100)
            {
                Console.WriteLine("My battery level is " +batteryLevel);
                Console.WriteLine("Saving ammo huh?");
                return batteryLevel;
            }
            else if (bulletNumber < 100)
            {
                batteryLevel -= bulletNumber;
                Console.WriteLine("BANG! BANG! BANG!");
                return batteryLevel;
            }
            else if (bulletNumber == 0)
            {
                Console.WriteLine("I'm all out of bullets and battery");
                return batteryLevel;
                
            }
            return batteryLevel;
        }

    }
}

