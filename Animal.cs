using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//My new project that I started by naming the solution
namespace Notes_Project_Solution
{

    //The first class that I defined by right-clicking on my solution ["add" --then-click--> "class"]
    internal class Animal
    {
        //This project will have these functions: virtual, override, new
        
        //Fun Fact: All of Microsoft Office was built in Visual Basic (or SQL Server I think)
        
        //This unused string that I defined here is just a placeholder for SQL Server Stored Data from our database of names in an excel-like orginization of data
        public string _name;



        //defined a string to so that later we can use the keyword to trigger:
        //virtual, override or new
        public string Sound()
        {
            //if this segment of code gets run, then popup a message in the center of our xaml app's screen.
            return "Animal Call";
        }
    }
}
