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
    /// Interaction logic for ListViewExample.xaml
    /// </summary>
    public partial class ListViewExample : Window
    {
        public ListViewExample()
        {
            InitializeComponent();
            List<User> users = new List<User>() { 
                new User() {Name="Jan Kowalski", Age=33},
                new User() {Name="Janina Kowalska", Age=36},
                new User() {Name="Marek Nowak", Age=43},
                new User() {Name="Maria Nowak", Age=13},
            };
            lvUsers.ItemsSource = users;
            
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = ValidateUser;
        }

        private bool ValidateUser(object obj)
        {
            if (string.IsNullOrEmpty(txtFilter.Text)) return true;
            User user = obj as User;
            if (user==null) return true;
            return user.Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) > -1;
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
