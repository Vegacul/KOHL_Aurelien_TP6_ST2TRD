
using System;
namespace behavioral_design_pattern
{
    public class Program
    {
        static void Main()
        {
            // Build a collection of student
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddStudent(new Student("Aurélien", 20170211));
            collection.AddStudent(new Student("Oussama", 20170212));
            collection.AddStudent(new Student("Sophia", 20170213));
            collection.AddStudent(new Student("Nicolas", 20170214));
            collection.AddStudent(new Student("Adrien", 20170215));
            collection.AddStudent(new Student("Mohamed", 20170216));

            // Create iterator of this collection
            Iterator iterator = collection.CreateIterator();
            //looping iterator   to show all the student without knowing how many student there is   
            Console.WriteLine("Iterating over collection:");

            for (Student  stud = iterator.First(); !iterator.IsCompleted; stud = iterator.Next())
            {
                Console.WriteLine($"StudentID : {stud.StudentID} & Name : {stud.Name}");
            }
            Console.Read();
        }
    }
}
