using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Project_Solution
{
    //created a new class and made it a child class to the parent class "Course"
    internal class OneOnOneClass : Course
    {
        //declared a name to represent an individual student
        Student _student;
        

        public OneOnOneClass(string courseName, string location,
            Student student) : base(courseName, location)
        {
            _student = student;
            ClassRoster = null; // null indicates it does not exist in memory
        }


        public OneOnOneClass(string courseName, string location,
            Teacher teacher, Student student) : base(courseName,
                location, teacher)
        {
            _student = student;
            Teacher = teacher;
            ClassRoster = null;
        }




    }
}
