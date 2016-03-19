using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class RobotRepairFleet : Robot
    {
        public RobotRepairFleet()
        {

        }

        public void repairFleetNames(string RobotBrand, int RobotBatteryLevel)
        {
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;

            AmericanRobot newAmerican = new AmericanRobot("Brad", "Apple", 100);
            JapaneseRobot newJapanese = new JapaneseRobot("Craig", "Sony", 100);
            AfricanRobot newAfrican = new AfricanRobot("Devin", "Samsung", 100);
            RussianRobot newRussian = new RussianRobot("Luke", "Toshiba", 100);


            List<Robot> repairFleet = new List<Robot>();

            repairFleet.Add(newAmerican);
            repairFleet.Add(newJapanese);
            repairFleet.Add(newAfrican);
            repairFleet.Add(newRussian);

            Console.WriteLine("Here is your fleet of Repair Robots");
            Console.WriteLine("----------------------");
            Console.WriteLine(newAmerican.robotName);
            Console.WriteLine(newJapanese.robotName);
            Console.WriteLine(newAfrican.robotName);
            Console.WriteLine(newRussian.robotName);

            Console.WriteLine("Repair fleet at your service!");

        }

        public bool LegRepairSystem()
        {
            Console.WriteLine("We'll get right on your repair!");
            repairLegs = true;
            Console.WriteLine("Your legs  are now repaired");
            return repairLegs;
        }
           
        public bool ArmRepairSystem()
        {
            Console.WriteLine("We'll get right on your repair!");
            repairArm = true;
            Console.WriteLine("Your arm  is now repaired");
            return repairArm;
        }
        
        public bool VoiceRepairSystem()
        {
            Console.WriteLine("We'll get right on your repair!");
            repairVoice = true;
            Console.WriteLine("Your voice is now repaired");
            return repairVoice;
        }
            
        public bool AmmoReserve()
        {
            Console.WriteLine("We'll restore your ammo clips!");
            ammoFull = true;
            Console.WriteLine("You now have full ammo");
            return ammoFull;

        }
            


        }
    }


