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
         public void Begin2()
         {
             int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(x * x);
         }
         public void Begin3()
         {
             int x = Convert.ToInt32(Console.ReadLine());
             int y = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(2*(x+y));
         }
         public void Begin12()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             double c= Math.Sqrt(a*a+b*b);
             double P = a + b + c;
             Console.WriteLine(c);
             Console.WriteLine(P);
         }
         public void Integer1()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(a/100);
         }
         public void Integer6()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(a / 10);
             Console.WriteLine(a % 10);
         }
         public void Integer30()
         {
             int a = Convert.ToInt32(Console.ReadLine());            
             int century = (a -1)/ 100 + 1;
             Console.WriteLine(century);           
   
         }
         public void Proc16(double x)
         {
            if (x < 0) Console.Write(-1);
            if (x == 0) Console.Write(0);
            if (x > 0) Console.Write(1);
         }
        public void Proc17(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D < 0) Console.Write(0); 
            if (D == 0) Console.Write(1); 
            if (D > 0) Console.Write(2); 
        }
        public double Proc18(double R)
        {
           double s = 3.14 * R * R;
           return s;

        }
        public double Proc19(double R1,double R2)
        {
            double s1 = 3.14 * R1 * R1;
            double s2 = 3.14 * R2 * R2;
            double s3 = Math.Max(s1, s2) - Math.Min(s1, s2);
            return s3;
        }
        public double Proc20(double a, double h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            double per = b * 2 + a;
            return per;
        }
        public int Proc21(int a, int b)
        {
            if (a > b)
            {
                return 0;
            }
            int sum = 0;
            for(int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
        public double Proc22(double a, double b,int op) 
        {
         switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
    }
        public double Proc23(double x, double y)
        {
            if ((x > 0) && (y > 0)) { return 1; }
            if ((x < 0) && (y > 0)) { return 2; }
            if ((x < 0) && (y < 0)) { return 3; }
            if ((x > 0) && (y < 0)) { return 4; }
            else { return 0; }
            
        }
        public bool Proc25(int x)
        {
            for(int i = 1; i * i <= x; i++)
            {
               if(i*i==x) return false;
            }
            return true;
            
        }
        public void Minmax9(int a)
        {
            int ni, maxn1=0, maxn2=0, max1 = -99999999, max2 = -99999999;
           
            for (int i = 0; i < a; i++)
            {
                ni=Convert.ToInt32(Console.ReadLine());
                if (ni > max1)
                {
                    max1 = ni;
                    maxn1 = i;
                }
                if (ni >= max2)
                {
                    max2 = ni;
                    maxn2 = i;
                }
            }
            Console.WriteLine(maxn1);
            Console.WriteLine(maxn2);
        }
        public void Minmax10(int n)
        {
            int g, minn1 = 0, maxn2 = 0, min1 = 99999999, max2 = -99999999;
            for (int i = 0; i < n; i++)
            {
               g = Convert.ToInt32(Console.ReadLine());
                if (g > max2)
                {
                    g = max2;
                    maxn2 = i;
                }
                if (g < min1)
                {
                    g = min1;
                    minn1 = i;
                }
            }
            Console.WriteLine(Math.Min(minn1, maxn2));
        }
        public void Minmax11(int n)
        {
            int g, minn1 = 0, maxn2 = 0, min1 = 99999999, max2 = -99999999;
            for (int i = 0; i < n; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (g > max2)
                {
                    g = max2;
                    maxn2 = i;
                }
                if (g < min1)
                {
                    g = min1;
                    minn1 = i;
                }
            }
            Console.WriteLine(Math.Max(minn1, maxn2));
        }
        public void Minmax12(int n)
        {
            int g, minn1 = 0,min1 = 9999999;
            for (int i = 0; i < n; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (g < min1&&g>0)
                {
                    min1 = g;
                   minn1 = i;
                }
            }
            Console.WriteLine(Math.Max(min1,0));
        }
        public void Minmax18(int a) {
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
        public void Array10()
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
  

             Console.ReadLine();
         }
    }
}
