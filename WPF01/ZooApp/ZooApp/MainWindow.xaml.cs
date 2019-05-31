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
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace ZooApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Setting SQL connection
        SqlConnection sqlConnection;

        public MainWindow()
        {

             
            InitializeComponent();
            //Enter string name from when setting up database connection window
            string connectionString = ConfigurationManager.ConnectionStrings["ZooApp.Properties.Settings.AcmeDBConnectionString"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            //Call ShowZoos method
            ShowZoos();
        }

        private void ShowZoos()
        {

            try
            {
                string query = "select * from Zoo";

                // Use (SqlDataAdapter) to create a connection to the database table to run query
                // the SqlDataAdapter can also be imagined like an interface to amke tables usable by C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    //Which information of the Table in Datatable should be shown in our Listbox?
                    listZoos.DisplayMemberPath = "Location";

                    //Which Value should be delivered when an item from our listbox is selected?
                    listZoos.SelectedValuePath = "Id";

                    //The reference to the Data the Listbox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;
                }

            }

            catch (Exception e)
            {
                //Show generic Execption message and convert to string.
                MessageBox.Show(e.ToString());
            }

        }
    }
}
