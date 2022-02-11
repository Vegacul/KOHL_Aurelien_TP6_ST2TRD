using System;
using System.Collections.Generic;
using System.Text;

namespace behavioral_design_pattern
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public Student(string name, int id)
        {
            Name = name;
            StudentID = id;
        }
    }
}