using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();

            house1.Paint("Green");
            Console.WriteLine(house1.CurrentColor());

            house1.Paint("Eggshell white");
            Console.WriteLine(house1.CurrentColor());

            House house2 = new House();
            house2.Paint("Cerulean");
            Console.WriteLine("House one is: " + house1.CurrentColor());
            Console.WriteLine("House two is: " + house2.CurrentColor());
        }
    }
}
