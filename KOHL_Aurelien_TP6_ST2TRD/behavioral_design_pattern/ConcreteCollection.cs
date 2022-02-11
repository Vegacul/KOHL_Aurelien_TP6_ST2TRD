using System;
using System.Collections.Generic;
using System.Text;


namespace behavioral_design_pattern
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Student> listStudents = new List<Student>();

        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets student count
        public int Count
        {
            get { return listStudents.Count; }
        }

        //Add students to the collection
        public void AddStudent(Student Student)
        {
            listStudents.Add(Student);
        }

        //Get student from collection
        public Student GetStudent(int IndexPosition)
        {
            return listStudents[IndexPosition];
        }
    }
}