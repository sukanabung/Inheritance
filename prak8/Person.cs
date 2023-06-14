using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        // Properties
        public string Name;
        public int Age;
        // Constructor
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public Person()
        {

        }
        // Method
        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun.", this.Name, this.Age);
        }
    }
    // Child Class
    public class Karyawan : Person
    {
        // Properties
        public string KaryawanID;
        public string Subject;

        // Constructor
        public Karyawan(string KaryawanID, string Subject)
        {
            this.KaryawanID = KaryawanID;
            this.Subject = Subject;
        }
        public Karyawan()
        {

        }

        // Override Method
        public void InfoPerson(string Subject, string KaryawanID)
        {
            this.Subject = Subject;
            this.KaryawanID = KaryawanID;
            Console.WriteLine("Saya disini sebagai {0} dengan ID Karyawan {1}.", this.Subject, this.KaryawanID);
        }
    }
}