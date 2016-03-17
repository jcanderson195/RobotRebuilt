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

            int robotRechargeTime = 6;
        }

        public int jumpingAfrican()
        {
            int jumpsAttempted = 0;
            int jumpsCompleted = jumpsAttempted += 3;
            Console.WriteLine("Jumping is fun!");
            return jumpsCompleted;
        }
    }
}
