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
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        SportsClubEntities db = new SportsClubEntities();
        Player P = new Player();
        Trainer T = new Trainer();
        Loginpage lp = new Loginpage();
        public Homepage()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            if (lp.UsertypeComBox.SelectedItem.ToString() == "Player")
            {
                var sporttypetxt = SporttypeCombox.SelectedItem.ToString().Split(' ');
                string sport = sporttypetxt.Last();
                Dataview.ItemsSource = db.Players.Where(x => x.Player_Name.Contains(SearchNametxtbox.Text) && x.Player_Sport == sport).ToList();
            }
        }
    }
}
