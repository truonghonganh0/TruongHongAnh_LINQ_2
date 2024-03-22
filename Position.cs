using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_LINQ_2
{
    class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Position(int id, string name, List<Employee> employees)
        {
            ID = id;
            Name = name;
            Employees = employees;
        }
    }
}
