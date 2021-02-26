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
using WF = System.Windows.Forms;
using System.Drawing;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                button.Width = 50;
            }
           
            Random rnd = new Random();
            while(true)
            {
                WF.Cursor.Position = new System.Drawing.Point(rnd.Next(0, 1920), rnd.Next(0, 1080));
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
