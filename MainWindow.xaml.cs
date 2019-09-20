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

namespace renieldavid.GPCONVERTER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBoxPercentage.Focus();

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {



            int x = int.Parse(txtBoxPercentage.Text);
            if (x == 98 || x == 99 || x == 100)
            {
                lblGP.Content = "1";
            }
            else if (x == 95 || x == 96 || x == 97)
            {
                lblGP.Content = "1.25";
            }
            else if (x == 92 || x == 93 || x == 94)
            {
                lblGP.Content = "1.5";
            }
            else if (x == 89 || x == 90 || x == 91)
            {
                lblGP.Content = "1.75";
            }
            else if (x == 86 || x == 87 || x == 88)
            {
                lblGP.Content = "2";
            }
            else if (x == 83 || x == 84 || x == 85)
            {
                lblGP.Content = "2.25";
            }
            else if (x == 80 || x == 81 || x == 82)
            {
                lblGP.Content = "2.5";
            }
            else if (x == 76 || x == 77 || x == 78 || x == 79)
            {
                lblGP.Content = "2.75";
            }
            else if (x == 75)
            {
                lblGP.Content = "3";
            }
            else if (x == 73 || x == 74)
            {
                lblGP.Content = "3.25";
            }
            else if (x == 71 || x == 72)
            {
                lblGP.Content = "3.5";
            }

            else if (x == 69 || x == 70)
            {
                lblGP.Content = "3.75";
            }
            else if (x == 67 || x == 68)
            {
                lblGP.Content = "4";
            }
            else if (x == 65 || x == 66)
            {
                lblGP.Content = "4.25";
            }
            else if (x == 63 || x == 64)
            {
                lblGP.Content = "4.5";
            }
            else if (x == 61 || x == 62)
            {
                lblGP.Content = "4.75";
            }
            else if (x == 60)
            {
                lblGP.Content = "5";
            }




        }

        private void LblPercentage_LostFocus(object sender, RoutedEventArgs e)
        {

            int z = int.Parse(txtBoxPercentage.Text);
            if (z < 60 || z > 100)
            {

                MessageBox.Show("Please Enter A Number From 60 to 100 Only");
                txtBoxPercentage.Text = "";
            }

        }


    }
}
