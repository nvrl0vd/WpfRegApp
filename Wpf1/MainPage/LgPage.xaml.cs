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
using Wpf1.DataHelper;
using Wpf1.MainPage;

namespace Wpf1.MainPage
{
    /// <summary>
    /// Логика взаимодействия для LgPage.xaml
    /// </summary>
    public partial class LgPage : Page
    {
        public LgPage()
        {
            InitializeComponent();
        }

        private void BtnCrAcc_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.mainFrm.Navigate(new RegPage());
        }
    }
}
