using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notes_Project_Solution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //made a list on the main page of our project
        List<Teacher> teachers = new List<Teacher>();



        //our xaml file is public, this code segment is default for New xaml project
        public MainWindow()
        {
            InitializeComponent(); //this code cue's our xaml app to run

            //create new instances
            Animal animal = new Animal();
            Hippo hungry = new Hippo();

            //MessageBox.Show("Hello World");
            MessageBox.Show(hungry.Sound());
        }

        public void AggregateExample()
        {
            // Aggrgate TAKES another object, but does not require
            Teacher will = new Teacher("", "Cram", 2);
            Course csi124 = new Course("Csi 124", "Downtown Renton");

            teachers.Add(will);
            teachers.Add(new Teacher("Anne", "Nguyen", 1));
            teachers.Add(new Teacher("Josh", "Emery", 3));

            csi124.Teacher = teachers[1];
            //print the data from the Teacher list stored at index location 1
            MessageBox.Show(csi124.Teacher.ToString());
        }
    }
}
