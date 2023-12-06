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

namespace Emt7an
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile(USSER u)
        {
            InitializeComponent();
            u.US_NAME = user1.Text;
            u.US_PASS = password1.Password;
            u.US_AGE = int.Parse(ag1.Text);
            u.US_GENDER = gender1.Text;
            u.US_CITY = city1.Text;
            u.US_PHONENUM = num1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
