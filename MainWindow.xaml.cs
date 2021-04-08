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

namespace ExtensionMethods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                if (i.IsOdd())
                {
                   
                    listBox.Items.Add(i.ToString() + " " + "True");
                }
                else
                {
                    listBox.Items.Add(i.ToString() + " " + "False");
                }
            }
          
          
        }
    }

    public static class IntExtension
    {
        public static bool IsOdd(this int integer)
        {
            if (integer % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
