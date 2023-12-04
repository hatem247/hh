using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ResetPasswordpage.xaml
    /// </summary>
    public partial class ResetPasswordpage : Page
    {
        SportsClubEntities db = new SportsClubEntities();
        Playerlogin PL = new Playerlogin();
        ForgetPasswordpage fpp = new ForgetPasswordpage();
        Loginpage lp = new Loginpage();
        public ResetPasswordpage()
        {
            InitializeComponent();
        }

        private void Confrimbtn_Click(object sender, RoutedEventArgs e)
        {
            if(Confirmtxtbox.Text == Passwordtxtbox.Text && fpp.UsertypeComBox.SelectedItem.ToString() == "Player")
            {
                PL.Player_Password = Passwordtxtbox.Text;
                db.Playerlogins.AddOrUpdate(PL);
                db.SaveChanges();
                NavigationService.Navigate(lp);
            }
        }
    }
}
