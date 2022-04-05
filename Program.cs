sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
            string str = dept.GetData();
            Console.WriteLine(str);
            Department dept2 = new Department(2, "civil", "pune");
            String str2 = dept2.GetData();
            Console.WriteLine(str2);





            Student stud = new Student();
            string str3 = stud.GetData();
            Console.WriteLine(str3);
            Student stud2 = new Student(102, "Piyush", "10th", "Thane");
            string str4 = stud2.GetData();
            Console.WriteLine(str4);
            Console.ReadLine();

        }
    }
}
