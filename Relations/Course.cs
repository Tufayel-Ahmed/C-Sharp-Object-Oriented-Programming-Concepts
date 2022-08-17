using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }
        public int MidResult { get; set; }
        public int FinalResult { get; set; }
        public string GetInfo()
        {
            return $"Course Code: {Code}{Environment.NewLine}Course Title: {Title}{Environment.NewLine}Credit Hour: {Credit}";
        }

        public int GetResult()
        {
            // Uses relationship
            Calculator calculator = new Calculator();
            int result = calculator.Add(MidResult, FinalResult);
            return result;
        }

    }
}
