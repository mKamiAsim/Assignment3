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

namespace Assignment.UI.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
           
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            txtStatus.Text = string.Empty;
            var service = new Assignment.Service.UserService();

            bool status = await service.LoginUser(txtUserName.Text.Trim(), txtpass.Password);

            if(status)
            {
                txtStatus.Text = "User Logined successfully.";
                txtStatus.Foreground = Brushes.Green;
            }
            else
            {
                txtStatus.Text = "Invalid Username/Password.";
                txtStatus.Foreground = Brushes.Red;
            }
        }
    }
}
