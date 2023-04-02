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

namespace WPFControls
{
    /// <summary>
    /// Interaction logic for DataGridExample.xaml
    /// </summary>
    public partial class DataGridExample : Window
    {
        public DataGridExample()
        {
            InitializeComponent();
            List<UserDob> users = new List<UserDob>() {
                new UserDob() {Id=1, Name="Jan Kowalski", DOB = new DateTime(1980,1, 1)},
                new UserDob() {Id=2, Name="Janina Kowalska", DOB = new DateTime(1960,1, 1)},
                new UserDob() {Id=3, Name="Marek Nowak", DOB = new DateTime(1990,1, 1)},
                new UserDob() {Id=4, Name="Maria Nowak", DOB = new DateTime(2000,1, 1)},
            };
            dgUsers.ItemsSource = users;
            dgUsersCols.ItemsSource = users;
        }
    }

    public class UserDob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public string Summary
        {
            get
            {
                return $"User: {Name}, data urodzenia: {DOB}";
            }
        }
    }
}
