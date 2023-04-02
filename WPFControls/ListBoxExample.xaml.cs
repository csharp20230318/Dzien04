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

namespace WPFControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<TaskProgress> items = new List<TaskProgress>
            {
                new TaskProgress() { Title = "Zadanie1", Progress = 30 },
                new TaskProgress() { Title = "Zadanie2", Progress = 10 },
                new TaskProgress() { Title = "Zadanie3", Progress = 70 },
                new TaskProgress() { Title = "Zadanie4", Progress = 60 }
            };
            lbTasks.ItemsSource = items;
        }
    }

    public class TaskProgress
    {
        public string Title { get; set; }
        public int Progress { get; set; }
    }
}
