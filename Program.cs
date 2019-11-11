using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsole
{
    class Student
    {


        //fields
        //private string _firstName;
        //private string _lastName;

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //ctor(s)
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //methods
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}";
        }


        static void Main(string[] args)
        {

            Student s1 = new Student("Joe1", "Schmoe");
            Student s2 = new Student("Joe2", "Schmoe");
            Student s3 = new Student("Joe3", "Schmoe");
            Student s4 = new Student("Joe4", "Schmoe");
            Student s5 = new Student("Joe5", "Schmoe");
            Student s6 = new Student("Joe6", "Schmoe");
            Student s7 = new Student("Joe7", "Schmoe");

            List<Student> ogStudents = new List<Student>()
            {
               s1,s2,s3,s4,s5,s6,s7
            };

            //foreach (Student s in students)
            //{
            //    Console.WriteLine(s);
            //}

            Student[] student2 = ogStudents.ToArray();
            Student[] student3 = ogStudents.ToArray(){
                
            };

        }
    }
}
