using System;

namespace Relations
{
    class Program
    {
        public static void Main(String[] args)
        {
            // One to One association relationship
            Address address = new Address();
            address.HouseNo = "41";
            address.RoadNo = "25";
            address.PostalCode = "3108";

            Person person = new Person();
            person.PresentAddress = address;

            Console.WriteLine(person.PresentAddress.HouseNo);

            // One to many association relationship
            Course course = new Course();
            course.Code = "101";
            course.Title = "C Programming";
            course.Credit = 3.0;

            Course course2 = new Course();
            course2.Code = "102";
            course2.Title = "C# Programming";
            course2.Credit = 3.5;

            Course course3 = new Course();
            course3.Code = "103";
            course3.Title = "Java Programming";
            course3.Credit = 4.0;

            Department department = new Department();
            department.Code = "CSE";
            department.Name = "Computer Science & Engineering";
            
            List<Course> courseList = new List<Course>();
            courseList.Add(course);
            courseList.Add(course2);
            courseList.Add(course3);
            
            department.courses = courseList;

            Console.WriteLine(department.GetInfo());


        }

    }
}
