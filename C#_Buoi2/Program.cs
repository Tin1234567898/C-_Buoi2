using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
           {
               new Student(1, "Anh Nguyen Tran", 15),
               new Student(2, "Be Hong Thi", 18),
               new Student(3, "Chanh Nguyen Duc", 20),
               new Student(4, "Dat Ho Nguyen", 16),
               new Student(5, "Em Tran Thi", 25)
           };

            //a. In danh sach
            Console.WriteLine("Danh sach hoc sinh: ");
            students.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            //b. DS HocSinh tu 15->18
            var rangeStudent = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("Danh sach hoc sinh tu 15->18: ");
            rangeStudent.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            //c. HS bat dau bang A
            var firstNameA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("Danh sach hoc tu bat dau bang chu 'A': ");
            if (firstNameA.Count > 0)
                foreach (var student in firstNameA)
                    Console.WriteLine(student);
            else
                Console.WriteLine("Khong co hoc sinh bat dau bang chu 'A': ");
            Console.WriteLine();

            //d. Tong tuoi
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi cac hoc sinh: {totalAge}");
            Console.WriteLine();

            //e. HS tuoi lon nhat
            int maxAge = students.Max(s => s.Age);
            var oldestStudent = students.First(s => s.Age == maxAge);
            Console.WriteLine("Hoc sinh co tuoi lon nhat: ");
            Console.WriteLine(oldestStudent);
            Console.WriteLine();

            //f. Sap xep tuoi
            var sortStudent = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("Danh sach sau khi sap xep theo tuoi: ");
            sortStudent.ForEach(s => Console.WriteLine(s));    

        }
    }
}
