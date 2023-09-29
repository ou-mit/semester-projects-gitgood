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
    /// Interaction logic for TAPage.xaml
    /// </summary>
    public partial class TAPage : Window
    {
        public TAPage()
        {
            InitializeComponent();
            updateList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AddStudent addstu = new AddStudent();
            addstu.Show();
        }

        public void updateList()
        {
            lstTAs.Items.Clear();
            DB db = new DB();
            foreach (var stu in db.TAs)
            {
                lstTAs.Items.Add(stu);
            }
        }
    }
}
