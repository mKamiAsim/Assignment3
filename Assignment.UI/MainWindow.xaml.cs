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

namespace Assignment.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetUsers_Click(object sender, RoutedEventArgs e)
        {
            ctrlContent.Content = new Views.GetUserView();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ctrlContent.Content = new Views.LoginView();
        }
    }
}
