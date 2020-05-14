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

namespace Tasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _Task1_Click(object sender, RoutedEventArgs e)
        {
            string[] A = _InputStr.Text.Split(' ');
            // int Resault = Convert.ToInt32(A);
            foreach (string Resault in A)
            {
                _OutputStr.Text = "Ответ"+Convert.ToString(Resault);
            }
            
        }
    }
}
