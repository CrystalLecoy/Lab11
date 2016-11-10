using PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"{person.getName()}");
            //Console.WriteLine($"{person.getAddress()}");

            Person person = new Person("John Doe", "2946 Castle Brook Lane");
            Console.WriteLine(person.ToString());

            Console.WriteLine(Environment.NewLine);

            Student student = new Student("John Doe II", "3957 Hollywood Blvd.", "Masters", 2017, 600.00);
            Console.WriteLine(student.ToString());

            Console.WriteLine(Environment.NewLine);

            Staff staff = new Staff("Smily Smith", "7395 Jefferson Ave.", "University of St. Louis", 46903.50);
            Console.WriteLine(staff.ToString());
        }
    }
}
