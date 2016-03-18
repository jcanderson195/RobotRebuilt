using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class AfricanRobot : Robot
    {
        public AfricanRobot (string RobotName, string RobotBrand, int RobotBatteryLevel)
        {

            robotName = RobotName;
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;

            
        }


        public int africanJumping()
        {
            int jumpsAttempted;
            batteryLevel = 100;
            decreaseBattery = batteryLevel;

            Console.WriteLine("Enter how many jumps I should do 0 - 10 ");
            jumpsAttempted = Convert.ToInt32(Console.ReadLine());

            if (jumpsAttempted == 0)
            {
                Console.WriteLine("C'mon there's jumping to do!");
                decreaseBattery = batteryLevel;
                Console.WriteLine("Battery Level: "+decreaseBattery);
                return decreaseBattery;
            }
            else if (jumpsAttempted <= 3)
            {
                Console.WriteLine("That's all? Fine. " + jumpsAttempted + " jumps completed");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (jumpsAttempted <= 6)
            {
                Console.WriteLine("Now we're talking! " +jumpsAttempted+" jumps completed");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (jumpsAttempted <= 9)
            {
                Console.WriteLine("Ok my legs are starting to hurt!");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (jumpsAttempted == 10)
            {
                Console.WriteLine("*Breaks legs*");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            return decreaseBattery;
        }
      
    }
}
