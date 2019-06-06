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



            //InsertUniversity();

            //InsertStudent();

            //insertLecture();

            insertStudentLecture();
        }



        public void InsertUniversity()
        {

            dataContext.ExecuteCommand("delete from University");

            //Create object of the Table Name
            University Birmingham = new University(); //if error? drag dbo from the .dbml file

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


        public void InsertStudent()
        {
            University Birmingham = dataContext.Universities.First(um => um.Name.Equals("Birmingham")); //this a lambda expression, which is the same as below:
                                                                                                        //"from university in dataContext.University where university == 'Birmingham' select university"

            //Add another University
            University Aston = dataContext.Universities.First(um => um.Name.Equals("Birmingham"));


            List<Student> students = new List<Student>(); //if error? drag dbo from the .dbml file

            //Add Students
            students.Add(new Student { Name = "Claire", Gender = "Female", UniversityId = Birmingham.Id });

            students.Add(new Student { Name = "Tom", Gender = "Male", University = Aston });
            students.Add(new Student { Name = "Kev", Gender = "Male", University = Birmingham });
            students.Add(new Student { Name = "Jenny", Gender = "Female", University = Aston });
            students.Add(new Student { Name = "Kos", Gender = "Female", University = Birmingham });


            //Insert on submit
            dataContext.Students.InsertAllOnSubmit(students);


            //Submit Changes
            dataContext.SubmitChanges();

            //View in the window
            MainDataGrid.ItemsSource = dataContext.Students;

        }


        public void insertLecture()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Maths" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Science" });

            //Submit Changes
            dataContext.SubmitChanges();

            //View in the window
            MainDataGrid.ItemsSource = dataContext.Lectures;

        }


        public void insertStudentLecture()
        {
            Student Claire = dataContext.Students.First(st => st.Name.Equals("Claire"));
            Student Tom = dataContext.Students.First(st => st.Name.Equals("Tom"));
            Student Kev = dataContext.Students.First(st => st.Name.Equals("Kev"));
            Student Jenny = dataContext.Students.First(st => st.Name.Equals("Jenny"));
            Student Kos = dataContext.Students.First(st => st.Name.Equals("Kos"));

            Lecture Math = dataContext.Lectures.First(st => st.Name.Equals("Math"));
            Lecture MScience = dataContext.Lectures.First(st => st.Name.Equals("Science"));

            //insert StudentLectures table
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Claire, Lecture = Math});
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tom, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Kev, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jenny, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Kos, Lecture = Math });

            //Submit Changes
            dataContext.SubmitChanges();

            //View in the window
            MainDataGrid.ItemsSource = dataContext.Lectures;

        }

    }

}