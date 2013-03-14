using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Michelin2.ServiceMichelinClient proxy = new Michelin2.ServiceMichelinClient();
            
        public MainWindow()
        {
            InitializeComponent();
            proxy.Open();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Michelin.WebServiceMeteo proxy = new Michelin.WebServiceMeteo();
            button1.Content = proxy.GetTemperature(textBox1.Text).ToString();
           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = proxy.GetPrix("MX").ToString() ;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("coucou les amis");
        }
    }
}
