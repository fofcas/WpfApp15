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

namespace WpfApp15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int n = int.Parse(N.Text);
                double x = 0;
                int ii = 0;
                const double c = 2.54;
                for (int i = 1; i < n + 1; i++)
                {
                    ii = i;
                    x += c;
                    Math.Round(x, 2);
                    Tabl.Items.Add(i + " дюйм " + " = " + x + " см");
                    
                }
                double fg =88.9+ 2.54;

                Vivod.Text = (ii + " дюйм " + " = " + x + " см"+fg );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
         }


    }
}
