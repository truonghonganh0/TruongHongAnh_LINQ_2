using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_LINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten nhan vien muon tim kiem: ");
            var searchByName = Console.ReadLine();
            var employee = employees.FirstOrDefault(employees => employees.Name.ToLower().Contains(searchByName.ToLower()));
            Console.WriteLine(employee != null ? $"Nhan vien: {employee.Name}" : "Khong tim thay nhan vien!!!");

            Console.WriteLine("Nhap ten phong ban muon tim kiem:");
            var searchByDepartment = Console.ReadLine();
            var department = departments.FirstOrDefault(d => d.Name.ToLower().Contains(searchByDepartment.ToLower()));
            Console.WriteLine(department != null ? $"Phong ban: {department.Name}" : "Khong tim thay phong ban!!!");

            Console.WriteLine("Nhap vi tri cong viec muon tim kiem:");
            var searchByPosition = Console.ReadLine();
            var position = positions.FirstOrDefault(p => p.Name.ToLower().Contains(searchByPosition.ToLower()));
            Console.WriteLine(position != null ? $"Vi tri cong viec: {position.Name}" : "Khong tim thay vi tri cong viec!!!");

            Console.WriteLine("\n---Tim kiem thong tin nhan vien---\n");
            Console.WriteLine("Nhap khoang tuoi muon tim kiem");
            Console.WriteLine("Nhap tuoi toi thieu: ");
            var minAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tuoi toi da: ");
            var maxAge = int.Parse(Console.ReadLine());
            var employeesByAge = employees.Where(employees => employees.Age >= minAge && employees.Age <= maxAge).ToList();
            employeesByAge.ForEach(employees => Console.WriteLine($"Employee found: {employees.Name}, Age: {employees.Age}"));

            Console.WriteLine("\nNhap vi tri cong viec: ");
            var positionName = Console.ReadLine();
            var employeesByPosition = employees
                .Where(e => e.Position.Name.ToLower().Contains(positionName.ToLower())).ToList();
            if (employeesByPosition.Count == 0)
                Console.WriteLine("Khong tim thay nhan vien");
            else
                employeesByPosition.ForEach(employees => Console.WriteLine($"Nhan vien: {employees.Name}, Vi tri: {employees.Position.Name}"));

            Console.WriteLine("\nNhap phong ban: ");
            var departmentName = Console.ReadLine();
            var employeesByDepartment = employees
                .Where(employees => employees.Department.Name.ToLower().Contains(departmentName.ToLower())).ToList();
            if (employeesByDepartment.Count == 0)
                Console.WriteLine("Khong tim thay nhan vien");
            else
                employeesByDepartment.ForEach(employees => Console.WriteLine($"Nhan vien: {employees.Name}, Phong ban: {employees.Department.Name}"));

            Console.ReadKey();
        }
        //danh sách vị trí công việc
        private static List<Position> positions = new List<Position>
        {
            new Position(1, "Quan ly", new List<Employee>()),
            new Position(2, "Designer", new List<Employee>()),
            new Position(3, "Ke toan", new List<Employee>()),
        };
        //danh sách phòng ban
        private static List<Department> departments = new List<Department>
        {
            new Department(1, "Nhan su", new List<Employee>()),
            new Department(2, "CNTT", new List<Employee>()),
            new Department(3, "Tai chinh", new List<Employee>()),

        };
        //danh sách nhân viên
        private static List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Nguyen Van A", 20, departments[0], positions[0]),
            new Employee(2, "Tran Van B", 22, departments[1], positions[1]),
            new Employee(3, "Le Van C", 24, departments[2], positions[2]),
        };
    }
}
