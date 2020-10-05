using System;

namespace ConsoleApp1
{
    using System;
    class Bikvadrat
    {

        static void soulutio(double t1, double t2)
        {
            if (t1 >= 0 && t2 >= 0)
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                double t3, t4;
                Console.WriteLine(Math.Sqrt(t1));
                t3 = Math.Sqrt(t1);
                Console.WriteLine(-t3);
                Console.WriteLine(Math.Sqrt(t2));
                t4 = Math.Sqrt(t2);
                Console.WriteLine(-t4);
            }
            if (t1 < 0 && t2 < 0)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет ");
            }
            if(t1<0 )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                double  t4;
                if (t2 >= 0)
                {
                    Console.WriteLine(Math.Sqrt(t2));
                    t4 = Math.Sqrt(t2);
                    Console.WriteLine(-t4);
                }
            }
            if (t2 < 0 )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                double t3;
                if (t1 >= 0)
                {
                    Console.WriteLine(Math.Sqrt(t1));
                    t3 = Math.Sqrt(t1);
                    Console.WriteLine(-t3);
                }
            }
        }
        static void di(double a, double b, double c)
        {
            if (a!=0)
            {
                double D = b * b - 4 * a * c;
                double t1, t2;
                if (D > 0)
                {
                    t1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                    t2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                    soulutio(t1, t2);
                }
              else  if (D == 0)
                {
                    
                        t1 = -b / (2 * a);
                    if (t1 > 0)
                    {
                        t1 = Math.Sqrt(t1);
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(t1);
                        Console.WriteLine(-t1);
                    }
                }
                else if(D<0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет ");
                }
               
                  
                
            }
            
           
        }
        //public static void CheckNumber(double number)
        //{
        //    double num = Math.Sqrt(number);
        //    string[] array = num.ToString().Split(',');
        //    if (array.Length == 1) Console.WriteLine("{0} - Число НОРМАЛЬНОЕ! math.sqrt = {1}", number, num);
        //    else Console.WriteLine("{0} - Число НЕНОРМАЛЬНОЕ! math.sqrt = {1}", number, num);
        //}
        static void Main()
        {
            
                Console.WriteLine("Кашурин Максим Владимирович ИУ5-34Б");
                Console.WriteLine("\nВведите коэффициенты А,В,С:");
            
            try
            {
                double a, b, c;
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                di(a, b, c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error , enter again!");
                double a, b, c;
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                di(a, b, c);
            }
           





            //    CheckNumber(4);

            Console.ReadLine();
        }


    }
}
