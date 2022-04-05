

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Constructor
{
    public class Department
    {
        private int id;
        private string name, location;
        public Department() //constructor
        {
            id = 1;
            name = "Admin";
            location = "Nashik";


        }
        public Department(int d_id, string d_name, string d_location)//parameterized constructor
        {
            id = d_id;
            name = d_name;
            location = d_location;


        }
        public string GetData()
        {
            return " Department Id " + id + "Department name" + name + "Location" + location;
        }
    }
}