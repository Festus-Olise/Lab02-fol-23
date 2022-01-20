using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_fol_23.Entities
{
    class Student: Person
    {
        public override int Age { get; set; }

        /*public string FirstName { get; set; }

        public string LastName { get; set; }*/

        public Subject Major { get; set; }

        public Student(string firstName, string lastName, int age, Subject major)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            nParticipants++;
        }
    }
}
