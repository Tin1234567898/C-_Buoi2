using System;

namespace C__Buoi2
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}";
        }
    }
}



