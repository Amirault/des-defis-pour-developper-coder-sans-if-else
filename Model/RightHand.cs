using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    public class RightHand : IShoot
    {
        public enum number { val1 = 1, val2 = 2, val3 = 3 };

        public string DisplayShooting()
        {
            return "main gauche";
        }
    }
}
