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

namespace Sports_Club
{
    /// <summary>
    /// Interaction logic for ForgetPasswordpage.xaml
    /// </summary>
    public partial class ForgetPasswordpage : Page
    {
        SportsClubEntities db = new SportsClubEntities();
        Player P = new Player();
        Playerlogin PL = new Playerlogin();
        Trainer T = new Trainer();
        Trainerlogin TL = new Trainerlogin();
        public ForgetPasswordpage()
        {
            InitializeComponent();
        }

        private void SumbitNicknamebtn_Click(object sender, RoutedEventArgs e)
        {
            if (Usernametxtbox.Text == PL.Player_User_Name && Nicknametxtbox.Text == PL.Player_Nick_Name && UsertypeComBox.SelectedItem.ToString() == "Player")
            {
                ResetPasswordpage rpp = new ResetPasswordpage();
                NavigationService.Navigate(rpp);
            }
            else if (Usernametxtbox.Text == TL.Trainer_User_Name && Nicknametxtbox.Text == TL.Trainer_Nick_Name && UsertypeComBox.SelectedItem.ToString() == "Trainer")
            {
                ResetPasswordpage rpp = new ResetPasswordpage();
                NavigationService.Navigate(rpp);
            }
            else if(UsertypeComBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose the user type :)");
            }
        }
    }
}
