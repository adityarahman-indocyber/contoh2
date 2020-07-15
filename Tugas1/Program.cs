using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// NOMBER 1
            string pilih2;
            int X, Y;
            double hasil, Z;
            string pilih;
            Console.WriteLine("System akan menggunakan pertanyaan seperti dibawah ini");
            Console.WriteLine("Pilih Option dari Nomber 1-3");
            Console.WriteLine("1. Fromula (X*Y)+(Z*Y)");
            Console.WriteLine("2. Fromula (X+Y+Z)/X");
            Console.WriteLine("3. Fromula (X-Z)*Y");
        ulangpilih:
            Console.Write("Masukan inputan antara 1 atau 2 atau 3 :");
            pilih = Console.ReadLine();
            pilih = pilih.Trim();
            Console.WriteLine("Inputan akan di trim");
            switch (pilih)

            {
                case "1":
                ulang:
                    Console.WriteLine("Masukan Nilai X = ");
                    try
                    {
                        X = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang;
                    }
                ulang1a:
                    Console.WriteLine("Masukan Nilai Y = ");
                    try
                    {
                        Y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang1a;
                    }
                ulang1b:
                    Console.WriteLine("Masukan Nilai Z = ");
                    try
                    {
                        Z = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang1b;
                    }
                    hasil = (X * Y) + (Z * Y);
                    Console.WriteLine("Hasilnya : " + hasil);
                    break;

                case "2":
                ulang2a:
                    Console.WriteLine("Masukan Nilai X = ");
                    try
                    {
                        X = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang2a;
                    }
                ulang2b:
                    Console.WriteLine("Masukan Nilai Y = ");
                    try
                    {
                        Y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang2b;
                    }
                ulang2c:
                    Console.WriteLine("Masukan Nilai Z = ");
                    try
                    {
                        Z = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang2c;
                    }
                    hasil = (X + Y + Z) / X;
                    Console.WriteLine("Hasilnya : " + hasil);
                    break;

                case "3":
                ulang3a:
                    Console.WriteLine("Masukan Nilai X = ");
                    try
                    {
                        X = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang3a;
                    }
                ulang3b:
                    Console.WriteLine("Masukan Nilai Y = ");
                    try
                    {
                        Y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang3b;
                    }
                ulang3c:
                    Console.WriteLine("Masukan Nilai Z = ");
                    try
                    {
                        Z = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Salah Silahkan coba lagi !");
                        goto ulang3c;
                    }
                    hasil = (X - Z) * Y;
                    Console.WriteLine("Hasilnya : " + hasil);
                    break;

                default:
                    Console.WriteLine("Maaf, Anda harus Input Antara 1 atau 2 atau 3");
                    goto ulangpilih;
                    break;
            }







        }
    }
}
