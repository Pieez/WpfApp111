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
        public Glavn g = new Glavn();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {

            if (Log.Text.Length > 0)
            {
                if (Pass.Password.Length > 0)
                {
                    g.Show();
                    Close();

                }
                else MessageBox.Show("Отсуствует логин");

            }
            else MessageBox.Show("Отсуствует пароль");

            
        }
    }
}
