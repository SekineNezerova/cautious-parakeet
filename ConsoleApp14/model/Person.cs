using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.model
{
    abstract class Person
    {


        private string _Name;
        private string _SurName;
        private int _Age;
       
        public string Name { get; set; }
        public string SurName { get; set; }
        protected int Age { get; set; }
        public Person(string name,string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
    }
}
