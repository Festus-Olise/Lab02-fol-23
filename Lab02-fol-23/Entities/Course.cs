using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_fol_23.Entities
{
    class Course
    {
        public Student[] students = new Student[MaxCapacity];
        public Teacher[] teachers = new Teacher[MaxCapacity];
        


        public int Capacity { get; set; }

        public static int MaxCapacity { get; set; }

        public Teacher teacher { get; set; }

        public string SubjectCode { get; set; }

        /*  public readonly Subject subject;

          public readonly Term term;*/

        public Subject subject { get; set; }

        public Term term { get; set; }

        public Course(Term term, Subject subject, string subjectCode, int maxCapacity)
        {
            this.term = term;
            this.subject = subject;
            SubjectCode = subjectCode;
            MaxCapacity = maxCapacity;

        }

        public void addStudent(Student student)
        {

            students.Append(student);
            Capacity++;

        }

        public void addTeacher(Teacher teacher)
        {
            teachers.Append(teacher);
        }

        public void printClassList()
        {

            Console.WriteLine("=========");
            Console.WriteLine("{0,-25}{1,25}", "Course Subject: " + this.subject, "Subject Code: " + SubjectCode);
            Console.WriteLine("{0,-15}{1,15}", "Term: " + this.term, "Capacity: " + Capacity + "/" + MaxCapacity);
            Console.WriteLine("Number of Students: {0}", Capacity);
            //Console.WriteLine("Instructor: Firstname: {0} Lastname: {1} Age: {2}", );
            Console.WriteLine("Course List");

            foreach (Student student in students)
            {
                Console.WriteLine("First Name: {0} LastName: {1} (Age: {2})", student.FirstName, student.LastName, student.Age);


            }

        }
    }
}
