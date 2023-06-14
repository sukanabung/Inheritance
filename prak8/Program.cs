using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Muhammad Yudha M";
            Person1.Age = 19;
            Person1.InfoPerson();

            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Gillas";
            Karyawan1.Age = 19;
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Dosen", "6026200404040001");

            Console.ReadLine();
        }
    }
}