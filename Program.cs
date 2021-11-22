using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Abramyan
{
    public class Abbr
    {

        public int Begin1(int x)
        {
           // int x = Convert.ToInt32(Console.ReadLine());
            return (4 * x);
            
        }
         public static void Begin2()
         {
             int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(x * x);
         }
         public static void Begin3()
         {
             int x = Convert.ToInt32(Console.ReadLine());
             int y = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(2*(x+y));
         }
         public static void Begin12()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             double c= Math.Sqrt(a*a+b*b);
             double P = a + b + c;
             Console.WriteLine(c);
             Console.WriteLine(P);
         }
         public static void Integer1()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(a/100);
         }
         public static void Integer6()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(a / 10);
             Console.WriteLine(a % 10);
         }
         public static void Integer30()
         {
             int a = Convert.ToInt32(Console.ReadLine());            
             int century = (a -1)/ 100 + 1;
             Console.WriteLine(century);           
   
         }
         public static void Proc16(double x)
         {
            if (x < 0) Console.Write(-1);
            if (x == 0) Console.Write(0);
            if (x > 0) Console.Write(1);
         }
        public static void Proc17(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D < 0) Console.Write(0); 
            if (D == 0) Console.Write(1); 
            if (D > 0) Console.Write(2); 
        }
        public static bool Proc25(int x)
        {
            for(int i = 1; i * i <= x; i++)
            {
               if(i*i==x) return false;
            }
            return true;
            
        }
        public static void Minmax18()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int minx=999999,posmin=0;
            int maxx=-999999,posmax=0;
            for(int i = 0; i < a; i++)
            {
                int g = Convert.ToInt32(Console.ReadLine());
                if (g > maxx)
                {
                    maxx = g;
                    posmax = i + 1;
                }
                if (g < minx)
                {
                    minx = g;
                    posmin = i + 1;
                }
            }
            Console.Write(Math.Max(Math.Max(posmin, posmax)- Math.Min(posmin, posmax)-1,0));
        }
        public static void Array10()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100000];
            for(int i = 0; i < n; i++)
            {
                int h = Convert.ToInt32(Console.ReadLine());
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {
                if (g[i] % 2 == 0)
                {
                    Console.WriteLine(g[i]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (g[i] % 2 != 0)
                {
                    Console.WriteLine(g[i]);
                }
            }
        }
        static void Main(string[] args)
         {
            Array10();


             Console.ReadLine();
         }
    }
}
