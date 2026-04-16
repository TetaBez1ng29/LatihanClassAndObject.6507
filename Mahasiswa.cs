using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassAndObject_6507
{
    internal class Mahasiswa
    {
        public string nim { get; set; }
        public string nama { get; set; }
        public float ipk { get; set; }

        public void registrasi()
        {
            Console.WriteLine("Nama: {0}", nama);
            Console.WriteLine("Nim: {0}", nim);
            Console.WriteLine("Ipk: {0}", ipk);
            Console.WriteLine("\nTelah melakukan registrasi");

        }
        public void isikrs()
        {
            Console.WriteLine("{0} sedang melakukan proses krs", nama);
        }
    }
}
