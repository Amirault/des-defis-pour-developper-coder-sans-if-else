using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    public class LeftHand : IShoot
    {
        public string DisplayShooting()
        {
            return "main gauche";
        }

        public enum number { val1 = 7, val2 = 8, val3 = 9 };


    }
}
