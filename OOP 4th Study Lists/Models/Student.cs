using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4th_Study_Lists.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Lab Laboratory { get; set; }

        public string ReflectInfo()
        {
            return $"{Name}{LastName}";
        }

    }
}
