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

            int robotRechargeTime = 6;

        }

        public int shootingAmerican()
        {
            int bulletNumber = 100;
            int gunShooting = bulletNumber -=3;
            return gunShooting;
        }

    }
}

