using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassAndObject_6507
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.nim = "25.11.6507";
            saya.nama = "Muhammad Arif Hidayatullah";
            saya.ipk = 4.00f;

            kamu.nim = "12346";
            kamu.nama = "tetaa";
            kamu.ipk = 3.70f;

            saya.registrasi();
            saya.isikrs();

            kamu.registrasi();
            kamu.isikrs();

            Console.ReadKey();

        }
    }
}
