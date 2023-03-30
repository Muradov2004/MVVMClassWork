using MVVMClassWork.Models;
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
using System.Xml.Linq;

namespace MVVMClassWork.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private List<Person> persons = new();
        public MainView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty)
            {
                persons.Add(new() { FirstName = txtFirstName.Text, LastName = txtLastName.Text });
                listView.Items.Add(new { FirstName = txtFirstName.Text, LastName = txtLastName.Text });
                txtFirstName.Clear();
                txtLastName.Clear();
            }
            else
                MessageBox.Show("You can not enter empty name or surname", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InfoWindow infoWindow = new();
            infoWindow.FirstNameBlock.Text = "FirstName : " + persons[listView.SelectedIndex].FirstName;
            infoWindow.LastNameBlock.Text = "LastName : " + persons[listView.SelectedIndex].LastName;
            infoWindow.Show();
        }
    }
}
