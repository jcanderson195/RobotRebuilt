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

            Console.WriteLine("Enter how many bullets you want to shoot 0 - 100: ");
            bulletNumber = Convert.ToInt32(Console.ReadLine());

            if (bulletNumber == 0)
            {
                Console.WriteLine("I'm all out of bullets and battery");
                Console.WriteLine("My battery level is " +batteryLevel);
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
                    newRepairFleet.AmmoReserve();


                    Console.WriteLine("Would you like to shoot an enemy robot? ");
                    Console.WriteLine("1. YES!");
                    Console.WriteLine("--------------");

                    int decision;
                    decision = Convert.ToInt32(Console.ReadLine());

                    if (decision == 1)
                    {
                        int WallieBatteryLevelShot;
                        WallieBatteryLevelShot = 100 - 99;

                        Console.WriteLine("Shooting Japanese Robot......");
                        Console.WriteLine("Wallie: Aghhhhhhh....You shot me!!!!!!");
                        Console.WriteLine("My battery level is at " + WallieBatteryLevelShot);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Please exit application!!!!!");
                    }
                }
                else if (choice == 2)
                {
                    RobotRechargeFleet newRechargeFleet = new RobotRechargeFleet();
                    newRechargeFleet.rechargeAbility("Samsung", 100);

                    Console.WriteLine("You have no ammo to shoot an enemy robot");

                }


                return batteryLevel;
            }
            else if (bulletNumber < 100)
            {
                batteryLevel -= bulletNumber;
                Console.WriteLine("BANG! BANG! BANG!");
                Console.WriteLine("My battery level is " + batteryLevel);
                 Console.WriteLine("Do you need a repair fleet? Do you need a recharge fleet?");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Repair Fleet");
                Console.WriteLine("2. Recharge Fleet");

                int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                {
                    RobotRepairFleet newRepairFleet = new RobotRepairFleet();
                    newRepairFleet.repairFleetNames("Samsung", 100);
                    newRepairFleet.AmmoReserve();

                    Console.WriteLine("Would you like to shoot an enemy robot? ");
                    Console.WriteLine("1. YES!");
                    Console.WriteLine("--------------");

                    int decision;
                    decision = Convert.ToInt32(Console.ReadLine());

                    if (decision == 1)
                    {
                        int WallieBatteryLevelShot;
                        WallieBatteryLevelShot = 100 - 99;

                        Console.WriteLine("Shooting Japanese Robot......");
                        Console.WriteLine("Wallie: Aghhhhhhh....You shot me!!!!!!");
                        Console.WriteLine("My battery level is at " + WallieBatteryLevelShot);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Please exit application!!!!!");
                    }

                }
                    else if (choice == 2)
                {
                    RobotRechargeFleet newRechargeFleet = new RobotRechargeFleet();
                    newRechargeFleet.rechargeAbility("Samsung", 100);


                    Console.WriteLine("Would you like to shoot an enemy robot? ");
                    Console.WriteLine("1. YES!");
                    Console.WriteLine("--------------");

                    int decision;
                    decision = Convert.ToInt32(Console.ReadLine());

                    if (decision == 1)
                    {
                        int WallieBatteryLevelShot;
                        WallieBatteryLevelShot = 100 - 99;

                        Console.WriteLine("Shooting Japanese Robot......");
                        Console.WriteLine("Wallie: Aghhhhhhh....You shot me!!!!!!");
                        Console.WriteLine("My battery level is at " + WallieBatteryLevelShot);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Please exit application!!!!!");
                    }

                }
               
                return batteryLevel;
            }
            else if (bulletNumber == 100)
            {
                Console.WriteLine("Saving ammo huh?");
                Console.WriteLine("My battery level is " + batteryLevel);

                Console.WriteLine("Would you like to shoot an enemy robot? ");
                Console.WriteLine("1. YES!");
                Console.WriteLine("--------------");

                int decision;
                decision = Convert.ToInt32(Console.ReadLine());

                if (decision == 1)
                {
                    int WallieBatteryLevelShot;
                    WallieBatteryLevelShot = 100 - 99;

                    Console.WriteLine("Shooting Japanese Robot......");
                    Console.WriteLine("Wallie: Aghhhhhhh....You shot me!!!!!!");
                    Console.WriteLine("My battery level is at " + WallieBatteryLevelShot);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Please exit application!!!!!");
                }


                return batteryLevel;
                
            }
            

            return batteryLevel;

           
        }



    }
}

