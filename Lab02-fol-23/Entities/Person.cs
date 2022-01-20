using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_fol_23.Entities
{
    abstract partial class Person
    {
        public static int nParticipants = 0;

        public abstract int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static int getNumberOfPersons()
        {

            return nParticipants;
        }
    }
}
