using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_21_03_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int RandomNumber = random.Next(0, 100);
            int Counter = 3;
            int input;

            do
            {
                if (Counter != 0)
                {
                    Console.Clear();
                    Console.WriteLine(RandomNumber);
                    Console.WriteLine();
                    Console.WriteLine("Kalan Tahmin Hakkın: " + Counter);

                    Console.Write("Tahmin et: ");
                    input = int.Parse(Console.ReadLine());
                    Counter--;

                    if (input > RandomNumber)
                    {
                        if (Counter == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Hakkınız bitti.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        { 
                        Console.Clear();
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                        Console.ReadKey();
                        }
                    }
                    else if (input < RandomNumber)
                    {
                        if (Counter == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Hakkınız bitti.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Daha büyük bir sayı giriniz.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(RandomNumber + " Doğru tahmin tebrikler!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hakkınız bitti.");
                    Console.ReadKey();
                    break;
                }
            } while (input != RandomNumber);
        }
    }
}
