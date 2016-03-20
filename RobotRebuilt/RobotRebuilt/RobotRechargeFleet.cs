using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class RobotRechargeFleet : Robot
    {

        public RobotRechargeFleet()
        {

        }

        public int rechargeAbility(string RobotBrand, int RobotBatteryLevel)
        {
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;

            AmericanRobot newAmerican = new AmericanRobot("Daniel", "Apple", 100);
            JapaneseRobot newJapanese = new JapaneseRobot("Matthew", "Sony", 100);
            AfricanRobot newAfrican = new AfricanRobot("Rodney", "Samsung", 100);
            RussianRobot newRussian = new RussianRobot("Sean", "Toshiba", 100);

            int rechargedBatteryLevel = 100;

            List<Robot> rechargeFleet = new List<Robot>();
           
            rechargeFleet.Add(newAmerican);
            rechargeFleet.Add(newJapanese);
            rechargeFleet.Add(newAfrican);
            rechargeFleet.Add(newRussian);

            Console.WriteLine("Here is your fleet of Recharge Robots");
            Console.WriteLine("----------------------");
            Console.WriteLine(newAmerican.robotName);
            Console.WriteLine(newJapanese.robotName);
            Console.WriteLine(newAfrican.robotName);
            Console.WriteLine(newRussian.robotName);

            Console.WriteLine("Recharge fleet at your service!");

            

            if (batteryLevel == 100)
            {
                Console.WriteLine("Our services are not needed.");
            }
            else if (batteryLevel >= 41)
            {
                Console.WriteLine("Are you sure you need a recharge?");
                return batteryLevel;

            }
            else if (batteryLevel <=40)
            {
                Console.WriteLine("Time to recharge!");
                increaseBattery += batteryLevel;
                Console.WriteLine("Your battery level is "+rechargedBatteryLevel);
                return rechargedBatteryLevel;
            }

            return rechargedBatteryLevel;
        }
        


    }
        
        

        

    }

