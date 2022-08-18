using System;

namespace InterfaceExample
{
    class Program
    {
        public static void Main(String[] args)
        {
            Student student = new Student();
            student.RegNo = "14177";

            string info = student.GetBasicInformation();

            Department department = new Department();
            department.Code = "CSE";
            string deInfo = department.GetBasicInformation();

            Course course = new Course();
            string coInfo = course.GetBasicInformation();
        }
    }
}
