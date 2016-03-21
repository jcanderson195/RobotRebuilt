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

            Console.WriteLine("Enter a volume level 0-10: ");
           volume = Convert.ToInt32(Console.ReadLine());

            if (volume == 0)
            {
                Console.WriteLine("*Shrugs shoulders*");
                decreaseBattery = batteryLevel;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                return decreaseBattery;
            }
            else if (volume <= 3)
            {
                Console.WriteLine("*whispers*Banzai");
                decreaseBattery = batteryLevel - volume*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);
                Console.WriteLine("Do you need a repair fleet? Do you need a recharge fleet?");
                Console.WriteLine("---------------------");
                
                Console.WriteLine("2. Recharge Fleet");

                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

               
                if (choice == 2)
                {
                    RobotRechargeFleet newRechargeFleet = new RobotRechargeFleet();
                    newRechargeFleet.rechargeAbility("Samsung", 100);

                }


                return decreaseBattery;
            }
            else if (volume <= 6)
            {
                Console.WriteLine("*talking*Banzai");
                decreaseBattery = batteryLevel - volume*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);

                Console.WriteLine("Do you need a repair fleet? Do you need a recharge fleet?");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Repair Fleet");
                Console.WriteLine("2. Recharge Fleet");

                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                {
                    RobotRechargeFleet newRechargeFleet = new RobotRechargeFleet();
                    newRechargeFleet.rechargeAbility("Samsung", 100);

                }

                return decreaseBattery;
            }
            else if (volume <= 9)
            {
                Console.WriteLine("*Screams*Banzai!!!!!");
                decreaseBattery = batteryLevel - volume*10;
                Console.WriteLine("Battery Level: " + decreaseBattery);

                Console.WriteLine("Do you need a repair fleet? Do you need a recharge fleet?");
                Console.WriteLine("---------------------");
                
                Console.WriteLine("2. Recharge Fleet");

                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                
                if (choice == 2)
                {
                    RobotRechargeFleet newRechargeFleet = new RobotRechargeFleet();
                    newRechargeFleet.rechargeAbility("Samsung", 100);

                }


                return decreaseBattery;
            }
            else if (volume == 10)
            {
                Console.WriteLine("*Breaks voice box*");
                decreaseBattery = batteryLevel - 100;
                Console.WriteLine("Battery Level: " + decreaseBattery);

                Console.WriteLine("Do you need a repair fleet? Do you need a recharge fleet?");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Repair Fleet");
                Console.WriteLine("2. Recharge Fleet");

                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    RobotRepairFleet newRepairFleet = new RobotRepairFleet();
                    newRepairFleet.repairFleetNames("Samsung", 100);
                    newRepairFleet.VoiceRepairSystem();
                }
                else if (choice == 2)
                {
                    RobotRechargeFleet newRechargeFleet = new RobotRechargeFleet();
                    newRechargeFleet.rechargeAbility("Samsung", 100);

                }


                return decreaseBattery;
            }
            return decreaseBattery;
        }

    }
}
