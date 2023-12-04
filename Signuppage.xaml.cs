﻿using System;
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
    /// Interaction logic for Signuppage.xaml
    /// </summary>
    public partial class Signuppage : Page
    {
        SportsClubEntities db = new SportsClubEntities();
        Player P = new Player();
        Playerlogin PL = new Playerlogin();
        Trainer T = new Trainer();
        Trainerlogin TL = new Trainerlogin();
        Loginpage lp = new Loginpage();
        public Signuppage()
        {
            InitializeComponent();
        }

        private void Signupbtn_Click(object sender, RoutedEventArgs e)
        {
            if(UsertypeComBox.SelectedItem.ToString() == "Player")
            {
                if (Usernametxtbox.Text == null)
                {
                    MessageBox.Show("Enter The Username");
                }
                else
                {
                    P.Player_Name = Nametxtbox.Text;
                    P.Player_Gender = Gendertxtbox.Text;
                    P.Player_Sport = Sporttxtbox.Text;
                    P.Player_Age = int.Parse(Agetxtbox.Text);
                    PL.Player_Nick_Name = Nicknametxtbox.Text;
                    PL.Player_User_Name = Usernametxtbox.Text;
                    PL.Player_Password = Passwordtxtbox.Text;
                    db.Players.Add(P);
                    db.Playerlogins.Add(PL);
                    db.SaveChanges();
                    NavigationService.Navigate(lp);
                    MessageBox.Show("Account Created");
                }
            }
            else if (UsertypeComBox.SelectedItem.ToString() == "Trainer")
            {
                if(Usernametxtbox.Text == null)
                {
                    MessageBox.Show("Enter The Username");
                }
                else
                {
                    T.Trainer_Name = Nametxtbox.Text;
                    T.Trainer_Gender = Gendertxtbox.Text;
                    T.Trainer_Sport = Sporttxtbox.Text;
                    T.Trainer_Age = int.Parse(Agetxtbox.Text);
                    TL.Trainer_Nick_Name = Nicknametxtbox.Text;
                    TL.Trainer_User_Name = Usernametxtbox.Text;
                    TL.Trainer_Password = Passwordtxtbox.Text;
                    db.Trainers.Add(T);
                    db.Trainerlogins.Add(TL);
                    db.SaveChanges();
                    NavigationService.Navigate(lp);
                    MessageBox.Show("Account Created");
                }
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
