using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class Student
    {
        private int _id;

        public int Id { get; }
        public string Fullname { get; set; }
        public int Point { get; set; }
       
        public void StudentInfo()
        {
            Console.WriteLine($"Id:{Id} Fullname:{Fullname} Point:{Point}");
        }

        private Student()
        {
            ++_id;
            Id = _id;
        }
        public Student(string Fullname,int Point)
        {
            this.Fullname = Fullname;
            this.Point = Point;
        }

    }
}
