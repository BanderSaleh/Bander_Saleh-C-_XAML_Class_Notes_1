using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Project_Solution
{
    internal class Teacher
    {
        // defined 3 strings to assign values to my Teacher object later
        string _firstName;
        string _lastName;
        string _yearsWorked;
        private string v1;
        private string v2;
        private int v3;

        // I then highlighted the 3 strings to convert to constructor:
        // right-clicked, then clicked Quick Actions & Refactorings,
        // then clicked generated constructor.
        // My data has now transformed into a constructor:
        public Teacher(string firstName, string lastName, string yearsWorked)
        {
            _firstName = firstName;
            _lastName = lastName;
            _yearsWorked = yearsWorked;
        }

        public Teacher(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
