using System;
using System.Collections.Generic;
using System.Text;

namespace line_comparision
{
    class equal
    {
      
        public static void equqlMethod(){
            Console.WriteLine("Enter coordinate point for line one");
            Console.Write("point for x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("point for y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("point for x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("point for y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate point for line second");
            Console.Write("point for a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("point for b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("point for a1 : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("point for b1 : ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            // formula for length of line
            var line1 = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));

            var line2 = Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2));

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Length of line1 is : " + line1);
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Length of line2 is : " + line2);

            Console.WriteLine("-----------------------------------for equal to method---------------------------------------------------------------------");
            if (line1.Equals(line2))
                Console.WriteLine("both line are equal");
            else
         //
                //
                Console.WriteLine("Both line have different length");
        }
    }
}
