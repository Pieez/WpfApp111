using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Glavn.xaml
    /// </summary>
    public partial class Glavn : Window
    {
        public Istok i = new Istok();
        public Del del = new Del();
        public Red red = new Red();
        public Vibr vibr = new Vibr();
        public RedVi redvi = new RedVi();
        public DelVi delvi = new DelVi();


        public Glavn()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            i.Show();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            del.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            red.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            vibr.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            redvi.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            delvi.Show();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Dob_Is(object sender, RoutedEventArgs e)
        {
            try
            {
                String connectionString = "server=ngknn.ru;Trusted_Connection=No;DataBase=Registr;User=33П;PWD=12357";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select* from Source", con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Is_Grid.ItemsSource = dt.DefaultView;
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void Dob_Is_Vi(object sender, RoutedEventArgs e)
        {
            try
            {
                String connectionString = "server=ngknn.ru;Trusted_Connection=No;DataBase=Registr;User=33П;PWD=12357";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select* from Emission", con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Is_ViGrid.ItemsSource = dt.DefaultView;
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
