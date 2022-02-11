using System;
using System.Collections.Generic;
using System.Text;

namespace behavioral_design_pattern
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first student
        public Student First()
        {
            current = 0;
            return collection.GetStudent(current);
        }
        // Gets next student
        public Student Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetStudent(current);
            }
            else
            {
                return null;
            }
        }
        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
} 