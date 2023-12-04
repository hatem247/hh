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
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        SportsClubEntities db = new SportsClubEntities();
        Player P = new Player();
        Playerlogin PL = new Playerlogin();
        Trainer T = new Trainer();
        Trainerlogin TL = new Trainerlogin();
        public Loginpage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Usernametxtbox.Text == PL.Player_User_Name && Passwordtxtbox.Text == PL.Player_Password && UsertypeComBox.SelectedItem.ToString() == "Player")
            {
                Homepage hp = new Homepage();
                NavigationService.Navigate(hp);
            }
            else if (Usernametxtbox.Text == TL.Trainer_User_Name && Passwordtxtbox.Text == TL.Trainer_Password && UsertypeComBox.SelectedItem.ToString() == "Trainer")
            {
                Homepage hp = new Homepage();
                NavigationService.Navigate(hp);
            }
            else if (UsertypeComBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please Choose the user type :)");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
