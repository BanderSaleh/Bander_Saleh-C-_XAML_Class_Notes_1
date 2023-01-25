using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Project_Solution
{
    //this class will inherit from a parent class
    internal class Hippo : Animal
    {
        //The : symbol means inherit
        //Child : Parent
        //Hippo : Animal
        //Derived : base

        //Access Modifers are all about giving *what* to other programmers?
        //A: Permission

        //Override = lets me change the Virtual Method "Sound" from the base
        public new string Sound()
        {
            //if this segment of code runs, then popup messege that says "Snorting Roar"
            return "Snorting Roar";
        }
    }
}
