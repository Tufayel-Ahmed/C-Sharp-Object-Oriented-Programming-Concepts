﻿using System;
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
    }
}
