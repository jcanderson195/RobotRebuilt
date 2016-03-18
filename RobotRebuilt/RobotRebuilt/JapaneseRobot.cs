using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class JapaneseRobot : Robot
    {

        public JapaneseRobot(string RobotName, string RobotBrand, int RobotBatteryLevel)
        {

            robotName = RobotName;
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;

        }
        public int japaneseScreaming()
        {

            int volume;
            int batteryLevel = 100;
            int decreaseBattery = batteryLevel;

            Console.WriteLine("Enter a volume level 1-10: ");
           volume = Convert.ToInt32(Console.ReadLine());

            if (volume == 0)
            {
                Console.WriteLine("*Shrugs shoulders*");
                decreaseBattery = batteryLevel;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (volume >= 1)
            {
                Console.WriteLine("*whispers*Banzai");
                decreaseBattery = batteryLevel - volume;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (volume >= 4)
            {
                Console.WriteLine("*talking*Banzai");
                decreaseBattery = batteryLevel - volume;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (volume >= 7)
            {
                Console.WriteLine("*Screams*Banzai!!!!!");
                decreaseBattery = batteryLevel - volume;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (volume == 10)
            {
                Console.WriteLine("*Breaks voice box*");
                decreaseBattery = batteryLevel - volume;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            return decreaseBattery;
        }

    }
}
