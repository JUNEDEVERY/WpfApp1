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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Model.tbResult = tbResult;
            Model.tbSignText = tbSign;
            
            cmbOperation.ItemsSource = Model.cmbOperation;
            

        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            Model.tbFirst = tbFirst.Text;
            Model.tbSecond = tbSecond.Text;
            Model.tbOperationResult = cmbOperation.SelectedIndex;
        }

        private void cmbOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.tbSignOperation = cmbOperation.SelectedIndex;
        }
    }
}
