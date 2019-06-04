using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linqwithXML
{
    class Program
    {
        static void Main(string[] args)
        {

            //We simply apply our Student-Structure to XML. 
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                            </Student>
                        </Students>";


            //Use XDocument to collect and display API like Xml
            XDocument studentXdoc = new XDocument();
            studentXdoc = XDocument.Parse(studentsXML);

            var students = from item in studentXdoc.Descendants("Student")
                           select new
                           {
                               Name = item.Element("Name").Value,
                               Age = item.Element("Age").Value,
                               Uni = item.Element("University").Value,
                           };

            foreach(var stu in students)
            {
                Console.WriteLine("Name: {0}, Age: {1}, University: {2}", stu.Name, stu.Age, stu.Uni);
            }




            //Order by just age from XDocument module
            var studentbyAge = from item in students
                               orderby item.Age
                               select item;

            foreach(var sty in studentbyAge)
            {
                Console.WriteLine("Name: {0}, Age: {1}, University: {2}", sty.Name, sty.Age, sty.Uni);
            }



            Console.Read();
        }


        
    }
}
