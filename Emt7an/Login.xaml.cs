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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        desktop_systemEntities db = new desktop_systemEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                USSER u = new USSER();
                if (user_name.Text != null && pass.Text != null)
                {

                    u = db.USSERs.First(x => x.US_NAME == user_name.Text && x.US_PASS == pass.Text);
                    MessageBox.Show("Signed in");
                    Profile profile = new Profile(u);
                    this.NavigationService.Navigate(profile);

                }
                else
                {
                    MessageBox.Show("Must enter data");
                }
            }
            catch
            {
                MessageBox.Show("Wrong data");
            }
        }
    }
}
