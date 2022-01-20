using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_fol_23.Entities
{
    class Teacher:Person

    {
        public override int Age { get; set; }
        public Subject CanTeach { get; set; }
        /*public string FirstName { get; set; }

        public string LastName { get; set; }*/

        public Teacher(string firstName, string lastName, int age, Subject canTeach)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            CanTeach = canTeach;
            nParticipants++;
        }
    }
}
