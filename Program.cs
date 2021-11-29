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


         public void Proc16()
         {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sign(a)+Sign(b));
        }
        public int Sign(double x)
        {
            if (x < 0) return-1;
            if (x > 0) return 1;
            else return 0;  
        }


        public void Proc17()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(RootsCount(a,b,c));
        }
        public int RootsCount(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D < 0) return 0;
            if (D == 0) return 1;
            if (D > 0) return 2;
            else return -1;
        }


        public void Proc18()
        {
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(CircleS(R));
        }
        public double CircleS(double R)
        {
            double s = 3.14 * R * R;
            return s;
        }


        public void Proc19()
        {
            double R1 = Convert.ToDouble(Console.ReadLine());
            double R2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(RingS(R1,R2));
        }
        public double RingS(double R1, double R2)
        {
            double s1 = 3.14 * R1 * R1;
            double s2 = 3.14 * R2 * R2;
            double s3 = Math.Max(s1, s2) - Math.Min(s1, s2);
            return s3;
        }


        public void Proc20()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TriangleP(a,h));
        }
        public double TriangleP(double a, double h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            double perimeter = b * 2 + a;
            return perimeter;
        }


        public void Proc21()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumRange(a, b));
            Console.WriteLine(SumRange(b, c));
        }
        public int SumRange(int a, int b)
        {
            if (a > b)
            {
                return 0;
            }
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }


        public void Proc22() 
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Calc(a,b,1));
            Console.WriteLine(Calc(a, b, 2));
            Console.WriteLine(Calc(a, b, 3));
        }
        public double Calc(double a, double b, int op)
        {
            switch (op)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                default: return 0;
            }
        }


        public void Proc23()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Quarter(x,y));
        }
            public int Quarter(double x, double y)
        {
            if ((x > 0) && (y > 0)) { return 1; }
            if ((x < 0) && (y > 0)) { return 2; }
            if ((x < 0) && (y < 0)) { return 3; }
            if ((x > 0) && (y < 0)) { return 4; }
            else { return 0; }

        }


        public void Proc24()
        {
            int a = 10;
            int b;
            for (int i = 0; i < a; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Even(b));
            }
            
        }
        public bool Even(int K)
        {
            if (K % 2 == 0) return true;
            else return false;
        }


        public void Proc25()
        {
            int a = 10;
            int b;
            for (int i = 0; i < a; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsSquare(b));
            }

        }
        public bool IsSquare(int x)
        {
            for (int i = 1; i * i <= x; i++)
            {
                if (i * i == x) return false;
            }
            return true;

        }

        public void Minmax9()
        {
            int a,x, maxposfirst = 0, maxpossecond = 0, maxfirst = 0, maxsecond = 0;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (i == 0 || x > maxfirst)
                {
                    maxfirst = x;
                    maxposfirst = i;
                }
                if (x >= maxsecond || i == 0)
                {
                    maxsecond = x;
                    maxpossecond = i;
                }
            }
            Console.WriteLine(maxposfirst);
            Console.WriteLine(maxpossecond);

        }


        public void Minmax10()
        {
            int x,g, minposfirst = 0, maxpossecond = 0, minfirst = 0, maxsecond = 0;
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
               g = Convert.ToInt32(Console.ReadLine());
                if (g > maxsecond)
                {
                     maxsecond=g;
                    maxpossecond = i;
                }
                if (g < minfirst)
                {
                    minfirst=g;
                    minposfirst = i;
                }
            }
            Console.WriteLine(Math.Min(minposfirst, maxpossecond));
        }


        public void Minmax11()
        {
            int a, x, minposfirst = 0, maxposfirst = 0, minfirst = 0, maxfirst = 0;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (i == 0 || x > maxfirst)
                {
                    maxfirst=x;
                    maxposfirst = i;
                }
                if (i == 0 || x < minfirst)
                {
                    minfirst=x;
                    minposfirst = i;
                }
            }
           Console.WriteLine(minposfirst > maxposfirst ? minposfirst : maxposfirst);
}

        public void Minmax12()
        {
            int g,n, minposfirst = 0, minfirst = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (i == 0 || (g < minfirst && g>0))
                {
                    minfirst = g;
                    minposfirst = i;
                }
            }
            Console.WriteLine(Math.Max(minfirst, 0));
        }

        public void Minmax13()
        {
            int g, n,evenpos = 0, maxeven= 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (i == 0 || (g > maxeven && g%2!=0))
                {
                    maxeven = g;
                    evenpos = i;
                }
            }
            Console.WriteLine(Math.Max(evenpos, 0));
        }
        public void Minmax14()
        {
            int g, b, upwardpos = 0, upward = 0;
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if ((g > b &&g <upward)||upward==0)
                {
                    upward = g;
                    upwardpos = i;
                }
            }
            if(upward>b)
            Console.WriteLine($"{upward} {upwardpos}");
            else
                Console.WriteLine($"0 0");
        }

        public void Minmax15()
        {
            int g, b,c, max = -1, maxnum = 0;
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if ((b < g) && (g < c) && ((g > max) || (maxnum == 0)))
                {
                    max = g;
                    maxnum = i;
                }
            }
            if (max > b&&max<c)
                Console.WriteLine($"{maxnum} {max}");
            else
                Console.WriteLine($"0 0");
        }
        public void Minmax16()
        {
            int minnum=0, n, g, min=0;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n;i++)
            {
                g = Convert.ToInt32(Console.ReadLine());

                if (g < min ||i == 0)
                {
                    min = g;
                    minnum = i;
                }
            }
            Console.WriteLine(minnum);
        }
        public void Minmax17()
        {
            int n, maxnum=0, g, max=0;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n;i++)
            {
                g = Convert.ToInt32(Console.ReadLine());

                if (g >= max || i == 0)
                {
                    max = g;
                    maxnum = i;
                }
            }
            Console.WriteLine(n - maxnum);
        }
        public void Minmax18() {
            int a,g;
            int min=0,posmin=0;
            int max=0,posmax=0;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (g > max||i==0)
                {
                    max = g;
                    posmax = i +1;
                }
                if (g < min || i == 0)
                {
                    min = g;
                    posmin = i +1;
                }
            }
            Console.Write(Math.Max(Math.Max(posmin, posmax)- Math.Min(posmin, posmax)-1,0));
        }

        public void Array1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int h;
            for (int i = 0; i < n; i++)
            {
                h = i * 2 + 1;
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {

                    Console.WriteLine(g[i]);

            }
           
        }

        public void Array2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int h;
            g[0] = 2;
            for (int i = 1; i <n; i++)
            {
                h = g[i-1] * 2 ;
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(g[i]);

            }

        }
        public void Array3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int a,d,h;
            a = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                h = a+i*d;
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(g[i]);
            }

        }

        public void Array4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int a, d,h;
            a = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            g[0] = a;
            for (int i = 1; i < n; i++)
            {
                h = g[i - 1] * d;
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(g[i]);
            }

        }
        public void Array5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int h;
            g[0] = 1;
            g[1] = 1;
            for (int i = 2; i < n; i++)
            {
                h = g[i - 1] +g[i - 2];
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(g[i]);
            }

        }
        public void Array6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int h,a,b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            g[0] = a;
            g[1] = b;
            for (int i = 2; i < n; i++)
            {
                h = g[i - 1] + g[i - 2];
                g[i] = h;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(g[i]);
            }

        }
        public void Array7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int a;
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                g[i] = a;
            }
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(g[i]);
            }

        }
        public void Array8()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int a,sum=0;
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                g[i] = a;
            }
            for (int i = 0; i < n; i++)
            {
                if (g[i] % 2 != 0)
                {
                    Console.WriteLine(g[i]);
                    sum++;
                }
            }
            Console.WriteLine(sum);

        }

        public void Array9()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
            int a, sum = 0;
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                g[i] = a;
            }
            for (int i = n; i > 0; i--)
            {
                if (g[i] % 2 == 0)
                {
                    Console.WriteLine(g[i]);
                    sum++;
                }
            }
            Console.WriteLine(sum);

        }
        public void Array10()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] g = new int[100];
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
