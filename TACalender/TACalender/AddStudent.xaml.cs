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

namespace TACalender
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            TA tA = new TA(txtFName.Text, txtMName.Text, txtLastName.Text, txtPrefName.Text, txtPersonEmail.Text, txtOUEmail.Text, Convert.ToInt32(txtNumSections.Text));

            DB db = new DB();
            db.TAs.Add(tA);
            db.SaveChanges();
        }
    }
}
