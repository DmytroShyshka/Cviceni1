using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        public static void Main(String[] args)
        {   
            //Intervals
            Interval interval = new Interval(5, 20);
            interval.Min = 5;
            interval.Max = 10;
            Interval Pen = interval.Pen(new Interval(6, 10));
            Console.WriteLine(interval.ToString());
            Console.WriteLine(interval.IsInInterval(6));
            Console.WriteLine(Pen.ToString());

            //Triangles
            Triangle kul1 = new Triangle(2, 3, 5);
            Console.WriteLine("Je rovnoramenny : " + kul1.isRovnoramenny());
            Console.WriteLine("Je rovnostranny : " + kul1.isRovnostranny());
            Console.WriteLine("Je pravouhly : " + kul1.isPravouhly());



        }
        
        
    }
}
