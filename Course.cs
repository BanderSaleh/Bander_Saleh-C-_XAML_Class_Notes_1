using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Project_Solution
{
    //Our 4 access modifiers:
    //private, public, internal, protected

    internal class Course
    {
        string _courseName;
        string _location;
        Teacher _teacher;

        //contains means an object is neseccary to work
       // List<Student> _classRoster = new List<Student>();

        

        //created a quick value for our list
        Course csi140 = new Course(
            "Csi 140",
            "Downtown Renton",
            new Teacher("Will", "Cram", 2),
            _classRoster);

        public Course(string courseName, string location)
        {
            CourseName = courseName;
            Location = location;
        }

        public Course(string courseName, string location, Teacher teacher)
        {
            CourseName = courseName;
            Location = location;
            Teacher = teacher;
        }

        //I'm not allowing users to pass in their own list of students

        // Aggragate
        // Has A indicate that an object is used IN a class
        // But can exist outside the class

        public Course(string courseName, string location,
            Teacher teacher, List<Student> classRoster)
        {
            _courseName = courseName;
            _location = location;
            _teacher = teacher;
            _classRoster = classRoster;
        }

        public static List<Student> classRoster { get; private set; }
        public static List<Student> _classRoster { get; private set; }
        public string CourseName { get => _courseName; set =>
                _courseName=value; }
        public string Location { get => _location; set =>
                _location=value; }

        internal Teacher Teacher {
            get {
                if(_teacher == null)
                {
                    return new Teacher("", "", 0);
                }
                return _teacher;
            }
            set => _teacher = value;
        }




        // The protected Access Modifieri allows the Class and
        // it's Derived Children to access members

        // Restricting users from setting the Class Roster of students.
        internal List<Student> ClassRoster { get =>
                _classRoster; set => _classRoster = value;
        }

        // I am creating a method to ADD students to the list.
        // But users are unable to DIRECTLY access that list.
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }
        


    }
}
