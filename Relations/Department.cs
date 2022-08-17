using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Course> courses { get; set; }

        public string GetInfo()
        {
            string info = $"Department Code: {Code}{Environment.NewLine}Department Name: {Name}{Environment.NewLine}";
            foreach (var course in courses)
            {
                info += $"{course.GetInfo()} {Environment.NewLine}";
            }
            return info;
        }
    }
}
