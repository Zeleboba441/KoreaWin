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

namespace WpfApp09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public People EditPeople { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            EditPeople = new People { Name = "Наталья Виллер", State = 228 };
            DataContext = this;
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://i.gifer.com/AwJO.mp4");
        }
    }
}
