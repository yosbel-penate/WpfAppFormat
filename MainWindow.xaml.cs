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

namespace WpfAppFormat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> persons = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            LoadClass();
        }

        internal List<Person> Persons { get => persons; set => persons = value; }

        void LoadClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Random a = new Random(4563);
                Persons.Add(new Person($"Pepe{i}", a.Next(5, 70), a.NextDouble()*1000));
            }
            dgrid.ItemsSource = Persons;
        }
    }
}
