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

namespace TACalender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DB dB = new DB();
            Course course = new Course();
            course.Subject = 3033;
            course.CourseNo = 001;
            dB.Courses.Add(course);
            dB.SaveChanges();
            Instructor i = new Instructor();    
            i.EduID = 1;
            i.LName = string.Empty; 
            i.OUEmail = string.Empty;
            i.FName = string.Empty;
            dB.Instructors.Add(i);
            dB.SaveChanges();

            foreach(var a in dB.Courses)
            {
                MessageBox.Show($"{a.CourseID}");
            }

        }

        private void btnHomeAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminPassword adminPassword = new AdminPassword();
            adminPassword.Show();
        }

        private void btnHomeTA_Click(object sender, RoutedEventArgs e)
        {
            TAPage tAPage = new TAPage();
            tAPage.Show();
        }
    }
}
