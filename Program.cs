using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsipemrograman4330
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Karyawan1 = new Karyawan();
            Karyawan Karyawan2 = new Karyawan();

            Karyawan1.Nik = "190302123";
            Karyawan1.Nama = "Paijo";
            Karyawan1.GajiBulanan = 3000000;

            Karyawan2.Nik = "190302124";
            Karyawan2.Nama = "Jono";
            Karyawan2.GajiBulanan = 2000000;

            Karyawan1.DataKaryawan();
            Karyawan2.DataKaryawan();

            Karyawan1.KenaikanGaji();
            Karyawan2.KenaikanGaji();

            Console.ReadKey();
        }
    }
}
