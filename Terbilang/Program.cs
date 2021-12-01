using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terbilang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long input;

            Console.Write("Masukkan angka: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terbilang: " + Terbilang(input));

            Console.ReadLine();
        }

        public static string Terbilang(long a)
        {
            string[] bilangan = new string[] { "", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", 
                "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas" };
            var kalimatTerbilang = "";
            if (a < 12)
            {
                kalimatTerbilang = bilangan[a];
            }
            else if (a < 20)
            {
                kalimatTerbilang = bilangan[a - 10] + " Belas";
            }
            else if (a < 100)
            {
                var angkaInput = a / 10;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 1));
                var angkaBelakang = a % 10;
                kalimatTerbilang = bilangan[angkaDepan] + " Puluh " + bilangan[angkaBelakang];
            }
            else if (a < 200)
            {
                kalimatTerbilang = "Seratus " + Terbilang(a - 100);
            }
            else if (a < 1000)
            {
                var angkaInput = a / 100;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 1));
                var angkaBelakang = a % 100;
                kalimatTerbilang = bilangan[angkaDepan] + " Ratus " + Terbilang(angkaBelakang);
            }
            else if (a < 2000)
            {
                kalimatTerbilang = "Seribu " + Terbilang(a - 1000);
            }
            else if (a < 10000)
            {
                var angkaInput = a / 1000;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 1));
                var angkaBelakang = a % 1000;
                kalimatTerbilang = bilangan[angkaDepan] + " Ribu " + Terbilang(angkaBelakang);
            }
            else if (a < 100000)
            {
                var angkaInput = a / 100;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 2));
                var angkaBelakang = a % 1000;
                kalimatTerbilang = Terbilang(angkaDepan) + " Ribu " + Terbilang(angkaBelakang);
            }
            else if (a < 1000000)
            {
                var angkaInput = a / 1000;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 3));
                var angkaBelakang = a % 1000;
                kalimatTerbilang = Terbilang(angkaDepan) + " Ribu " + Terbilang(angkaBelakang);
            }
            else if (a < 10000000)
            {
                var angkaInput = a / 1000000;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 1));
                var angkaBelakang = a % 1000000;
                kalimatTerbilang = Terbilang(angkaDepan) + " Juta " + Terbilang(angkaBelakang);

            }
            else if (a < 100000000)
            {
                var angkaInput = a / 1000000;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 2));
                var angkaBelakang = a % 1000000;
                kalimatTerbilang = Terbilang(angkaDepan) + " Juta " + Terbilang(angkaBelakang);
            }
            else if (a < 1000000000)
            {
                var angkaInput = a / 1000000;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 3));
                var angkaBelakang = a % 1000000;
                kalimatTerbilang = Terbilang(angkaDepan) + " Juta " + Terbilang(angkaBelakang);
            }
            else if (a == 1000000000)
            {
                var angkaInput = a / 1000000000;
                var angkaDepan = Convert.ToInt32(angkaInput.ToString().Substring(0, 1));
                kalimatTerbilang = Terbilang(angkaDepan) + " Milyar";
            }
            else
            {
                kalimatTerbilang = "Input tidak valid";
            }
            var pisah = kalimatTerbilang.Split(' ');
            List<string> full = new List<string>();// = [];
            for (var i = 0; i < pisah.Length; i++)
            {
                if (pisah[i] != "") { full.Add(pisah[i]); }
            }
            return CombineTerbilang(full.ToArray());
        }
        static string CombineTerbilang(string[] arr)
        {
            return string.Join(" ", arr);
        }
    }
}
