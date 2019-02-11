﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
