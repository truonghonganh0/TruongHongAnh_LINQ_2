using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_LINQ_2
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; } 
        public Position Position { get; set; }

        public Employee(int id, string name, int age, Department department, Position position)
        {
            ID = id;
            Name = name;
            Age = age;
            Department = department;
            Position = position;
        }
    }
}
