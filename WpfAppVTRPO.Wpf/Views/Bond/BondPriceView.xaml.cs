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
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.Views.Bond
{
    /// <summary>
    /// Логика взаимодействия для BondPriceView.xaml
    /// </summary>
    public partial class BondPriceView : UserControl
    {
        public BondPriceView()
        {
            InitializeComponent();
           /* DataContext = new BondViewModel();*/
        }
    }
}
