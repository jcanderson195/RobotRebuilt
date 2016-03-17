using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRebuilt
{
    class Program
    {
        static void Main(string[] args)
        {

            AmericanRobot Robbie = new AmericanRobot("Robbie", "Apple", 100);
            JapaneseRobot Wallie = new JapaneseRobot("Wallie", "Sony", 100);
            AfricanRobot Dodger = new AfricanRobot("Dodger", "Samsung", 100);
            RussianRobot Charlie = new RussianRobot("Charlie", "Toshiba", 100);
            
        }
    }
}
