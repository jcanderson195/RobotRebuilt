using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class RussianRobot : Robot
    {
        public RussianRobot(string RobotName, string RobotBrand, int RobotBatteryLevel)
        {

            robotName = RobotName;
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;

            int robotRechargeTime = 4;

            

        }

        public int wavingRussian()
        {
            int wavesAttempted = 0;
            int wavesCompleted = wavesAttempted += 2;
            Console.WriteLine("Hello good friend!");
            return wavesCompleted;
        }
    }
}
