using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rightHand = new List<int> {1,2,3};
            List<int> lefttHand = new List<int> {7,8,9};
            int number = new Random().Next(10);

            bool isRightHand = rightHand.Contains(number);

            IShoot shoot = new RightHand();

            shoot.DisplayShooting();
        }
    }
}
