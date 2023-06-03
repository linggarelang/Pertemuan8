using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write('\n');
            Person person1 = new Person();
            person1.Name = "Linggar Elang Pratama";
            person1.Age = 18;
            person1.infoPerson();

            Person person2 = new Person("Linggar", 18);


            Karyawan karyawan1 = new Karyawan();
            karyawan1.karyawanID = 22114849;
            karyawan1.subject = "Linggar Elang";
            karyawan1.infoKaryawan();

            Karyawan karyawan2 = new Karyawan("Linggar Elang");

            // for visual studio
            //Console.ReadKey();
        }
    }
}