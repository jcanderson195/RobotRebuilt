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
            else if (jumpsAttempted <= 6)
            {
                Console.WriteLine("Now we're talking! " +jumpsAttempted+" jumps completed");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
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
            else if (jumpsAttempted <= 9)
            {
                Console.WriteLine("Ok my legs are starting to hurt!");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
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
            else if (jumpsAttempted == 10)
            {
                Console.WriteLine("*Breaks legs*");
                decreaseBattery = batteryLevel - jumpsAttempted*10;
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
                    newRepairFleet.LegRepairSystem();
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
