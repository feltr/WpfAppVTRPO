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

namespace VTRPO.Wpf.Views
{
    /// <summary>
    /// Логика взаимодействия для EntryView.xaml
    /// </summary>
    public partial class EntryView : UserControl
    {
        public EntryView()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная программа применяет методы для математического расчета финансовых операций. Для этого выберите из списка подходящий вариант расчета и в появившемся окне выберите из подходящих списков, что хотите расчитать. После нажатия на кнопку (Расчитать), выведится результат операций. В окне для расчета процентов присутствует график для наглядности, в окне форвардной цены валюты и товара есть возможность создания отчета из последних введенных данных. Приятного пользования.");
        }
    }
}
