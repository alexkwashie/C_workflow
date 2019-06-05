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
using System.Configuration; //Add this from the Reference dropdown in the solution Explorer (on left)

namespace linqWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSQLclassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            String connectionString = ConfigurationManager.ConnectionStrings["linqWPF.Properties.Settings.AcmeDBConnectionString"].ConnectionString;

            dataContext = new LinqToSQLclassesDataContext(connectionString);



            InsertUniversity();

        }



        public void InsertUniversity()
        {

            dataContext.ExecuteCommand("delete from University");

            //Create object of the Table Name
            University Birmingham = new University();

            //Add Value to table name column 
            Birmingham.Name = "Birmingham";

            University Aston = new University();

            //Add Value to table name column 
            Aston.Name = "Aston";

            //Insert on submit
            dataContext.Universities.InsertOnSubmit(Birmingham);
            dataContext.Universities.InsertOnSubmit(Aston);

            //Submit Changes
            dataContext.SubmitChanges();

            //View in the window
            MainDataGrid.ItemsSource = dataContext.Universities;




        }



    }

}
