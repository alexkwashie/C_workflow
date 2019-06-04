using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsandQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new object and initiate it
            UniversityManager meo = new UniversityManager();

            //meo.maleStudents();

            //meo.SortStudentsByAge();

            //meo.PrincetonStudent();





            int[] someInts = { 12, 23, 31, 5, 10, 22, 9 };

            //Orders by smallest to highest
            IEnumerable<int> straights = from i in someInts orderby i select i;

            //Orders by highest to smallest (reversed)
            IEnumerable<int> reversedNums = straights.Reverse();
            //#OR
            IEnumerable<int> reversedNum2 = from i in someInts orderby i descending select i;


            foreach (int item in reversedNums)
            {
                Console.WriteLine(item);
            }


            meo.StudentandUniversiyColloection();

            Console.ReadKey();

                                 

            /*
            Console.WriteLine("Enter Student ID");
            
            try
            {
                int IDD = Convert.ToInt32(Console.ReadLine());

                meo.StudentUniId(IDD);
                
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong Value");
            }

            Console.ReadKey();
            */


        }
    }
     


    //Step 3
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> Student;



        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            Student = new List<Student>();


            //Add Universities
            universities.Add(new University { Id = 1, Name = "UCLA" });
            universities.Add(new University { Id = 2, Name = "Princeton" });

            //Add Students
            Student.Add(new Student { Name = "Joe", Age = 42 , Id = 1, Gender = "Male", UniId = 1});
            Student.Add(new Student { Name = "Kev", Age = 34, Id = 2, Gender = "Male", UniId = 2 });
            Student.Add(new Student { Name = "Xoe", Age = 19, Id = 3, Gender = "Female", UniId = 2 });
            Student.Add(new Student { Name = "Nuel", Age = 26, Id = 4, Gender = "Male", UniId = 1 });
            Student.Add(new Student { Name = "poli", Age = 25, Id = 5, Gender = "Female", UniId = 1 });

        }


        //Select only male students
        public void maleStudents()
        {
            IEnumerable<Student> males = from word in Student where word.Gender == "Male" select word;

            Console.WriteLine("Mare are:");

            foreach(Student student in males)
            {
                //the print method is From the Student Class
                student.Print();
            }
        }


        //Select and Order by Age
        public void SortStudentsByAge()
        {
            var sortedStudents = from student in Student orderby student.Age  select student;

            Console.WriteLine("Student Ordered Age: ");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }

        }


        //All Students from Princeton
        public void PrincetonStudent()
        {
            IEnumerable<Student> princetionStu = from student in Student
                                                 join university in universities on
                                                 student.UniId equals university.Id
                                                 where university.Name == "Princeton"
                                                 select student;

            foreach (Student student in princetionStu)
            {
                //the print method is From the Student Class
                student.Print();
            }

        

        }


               
        
        public void StudentUniId(int Id)
        {

            IEnumerable<Student> studentID = from student in Student
                                                 join university in universities on
                                                 student.UniId equals university.Id
                                                 where university.Id == Id
                                                 select student;

            foreach (Student student in studentID)
            {
                //the print method is From the Student Class
                student.Print();
            }

        }


        public void StudentandUniversiyColloection()
        {
            var newCollection = from student in Student
                                 join university in universities on student.UniId equals university.Id
                                 orderby student.Name
                                 select new { studentName = student.Name, universityName = university.Name}; //Create new variable to hold names

            foreach (var student in newCollection)
            {
                Console.WriteLine("Student name is: {0} and University Name is: {1}", student.studentName, student.universityName);
            }
        }





    }

    


    //Step 1
    class University
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine( "Universty: {0} with ID: {1}", Id, Name );
        }
    }





    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }


        //Foreign key
        public int UniId { get; set; }


        public void Print()
        {
            Console.WriteLine("Name: {0}, Gender: {1}, Age: {2} and Uni_ID: {3}", Name, Gender, Age, UniId);
        }
    }
}
