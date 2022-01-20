using Lab02_fol_23.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02School
{
    class Lab02School
    {
        static void Main(string[] args)
        {
            //Create three Coursees
            Course myEnglishCourse = new Course(Term.FALL, Subject.English, "1100", 15);
            Course myPhilosophyCourse = new Course(Term.SPRING, Subject.Philosophy, "2300", 8);
            Course myPsychologyCourse = new Course(Term.SUMMER, Subject.Psychology, "3500", 5);

            //Add 5 students to the english Course and one teacher
            myEnglishCourse.addStudent(new Student("Natiliya", "Peroditti", 21, Subject.English));
            myEnglishCourse.addStudent(new Student("Hunter", "Kledjsen", 35, Subject.English));
            myEnglishCourse.addStudent(new Student("Nikola", "Coughland", 26, Subject.English));
            myEnglishCourse.addStudent(new Student("Onyekachi", "Arthursson", 23, Subject.Philosophy));
            myEnglishCourse.addStudent(new Student("Abílio", "Ingesson", 22, Subject.Philosophy));
            myEnglishCourse.addTeacher(new Teacher("Tom", "Blaine", 40, Subject.English));

            //Add 7 students to the philisosphy Course and one teascher
            myPhilosophyCourse.addStudent(new Student("Alex", "Thurstan", 34, Subject.Philosophy));
            myPhilosophyCourse.addStudent(new Student("Nidia", "Uzun", 34, Subject.English));
            myPhilosophyCourse.addStudent(new Student("Seumas", "Romeijnders", 23, Subject.Philosophy));
            myPhilosophyCourse.addStudent(new Student("Ikenna", "Leonards", 43, Subject.Philosophy));
            myPhilosophyCourse.addStudent(new Student("Jathibiyya", "Cruz", 32, Subject.Philosophy));
            myPhilosophyCourse.addStudent(new Student("Neven", "Keifer", 28, Subject.Psychology));
            myPhilosophyCourse.addStudent(new Student("Keiko", "Jonkcers", 27,Subject.Philosophy));
            myPhilosophyCourse.addTeacher(new Teacher("Joby", "Rielly", 36, Subject.Philosophy));

            //Add 3 students to the psych Course and one teacher
            myPsychologyCourse.addStudent(new Student("Devi", "Frank", 45, Subject.History));
            myPsychologyCourse.addStudent(new Student("Mirko", "Ward", 28, Subject.Psychology));
            myPsychologyCourse.addStudent(new Student("Freddy", "Ezra", 18, Subject.Psychology));
            myPsychologyCourse.addTeacher(new Teacher("Tom", "Teacher", 54, Subject.Psychology));

            //Print the class lists
            myPsychologyCourse.printClassList();
            myEnglishCourse.printClassList();
            myPhilosophyCourse.printClassList();

            //Show the number the peeople in the school
            Console.WriteLine("---\nHeadcount for School: {0}", Person.getNumberOfPersons());

            Console.ReadLine();
        }
    }
   }