using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    interface IAreaCalc
    {
        double radius { get; set; }

        void area(double radius);
       
    }
    interface IAreaCalc2
    {
        double width { get; set; }
        double length { get; set; }
        void area(double width,double length);
      
    }
    internal class Interface : IAreaCalc, IAreaCalc2
    {
      double IAreaCalc.radius { get; set; }
        double IAreaCalc2.length { get; set; }
            double IAreaCalc2.width { get; set; }
        void IAreaCalc.area(double radius)
        {
            Console.WriteLine(radius * radius * 3.14);
        }
        void IAreaCalc2.area(double width, double length) { Console.WriteLine(width * length); }
        static void Main(string[] args)
        {
            IAreaCalc circle = new Interface();
            circle.area(10);
            IAreaCalc2 rectangle    = new Interface();
            rectangle.area(40, 50);
        }
    }


}
