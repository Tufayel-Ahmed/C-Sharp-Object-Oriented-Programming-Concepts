using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Department : IInformation, IPrinter
    {
        public Department()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public string GetBasicInformation()
        {
            return $"Code: {Code} Name: {Name} Total Students: {Students.Count}";
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void SetIPAddress(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
