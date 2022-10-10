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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

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
                    DataTable user = Select("SELECT * FROM [dbo].[nik] WHERE [a] = '" + Log.Text + "' AND [b] = '" + Pass.Password + "'");
                    if (user.Rows.Count > 0)
                    {   
                        g.Show();
                        Close();
                    }
                    else MessageBox.Show("Неправильный логин и пароль");
                }
                else MessageBox.Show("Отсуствует пароль");

            }
            else MessageBox.Show("Отсуствует логин");

            
        }
    }
}
