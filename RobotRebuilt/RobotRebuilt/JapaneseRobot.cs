using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class JapaneseRobot :Robot
    {

        public JapaneseRobot (string RobotName, string RobotBrand, int RobotBatteryLevel)
        {

            robotName = RobotName;
            robotBrand = RobotBrand;
            robotBatteryLevel = RobotBatteryLevel;     

        }

        public int screamingJapanese()
        {
            int volume = 0;
            int volumeIncrease = volume += 10;
            Console.WriteLine();
            return volume;
        }

    }
}
