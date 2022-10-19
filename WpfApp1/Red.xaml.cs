using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Логика взаимодействия для Red.xaml
    /// </summary>
    public partial class Red : Window
    {
        public Red()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");

            SqlConnection sqlConnection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=Registr;User=33П;PWD=12357");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        private void Izmen(object sender, RoutedEventArgs e)
        {

            DataTable dataTable = Select("update Source SET Name ='" + Istok_text + "', Adress ='" + Adres_text + "' where IDSource = '" + id_text + "'");
            Glavn g = new Glavn();

            g.Show();
            Close();

        }

        private void Otmen(object sender, RoutedEventArgs e)
        {
            Glavn g = new Glavn();
            g.Show();
            Close();
        }
    }
}
