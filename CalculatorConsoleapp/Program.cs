using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            //int a = 10; // declaration variable a, dg nilai awal 10;
            //int b = 6; // declaration variable b, dg nilai awal 6;

            Console.Write("Input nilai a = ");
            int a = int.Parse(Console.ReadLine()); //Proses casting

            Console.Write("Input nilai b = ");
            int b = int.Parse(Console.ReadLine()); //Proses casting

            Console.WriteLine();//tambah baris kosong

            Console.WriteLine("Hasil Penambahan dari " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan dari {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian dari {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian dari {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang aja lah,Monggo");
            Console.ReadKey();
        }
        
        
        
       static int Penambahan (int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
