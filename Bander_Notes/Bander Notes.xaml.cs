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
using System.Windows.Shapes;

namespace Notes_Project_Solution.Bander_Notes
{
    /// <summary>
    /// Interaction logic for Bander_Notes.xaml
    /// </summary>
    public partial class Bander_Notes : Window
    {
        public Bander_Notes()
        {
            InitializeComponent(); //start my new xaml window program for notes (next time :eyeroll:)
            // To get this convenient File.xaml.cs document for note taking next time, follow these steps:
            // Right-click my project's Solution file --> click "Add" --> click "New Folder"
            // Right-click on the new folder I created for the project's notes --> click "add" --> click "Window(WPF)"
        }
    }
}
