using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.model
{
    class Student:Person
    {
        public int _age;

        public int IQRank;
        public int LanguageRank;
        public void ExamResult(int examresult)
        {
            examresult = IQRank + LanguageRank;
            if (examresult<120)
            {
                Console.WriteLine("sinifde qaldi");
            }

        
        
        }
        public Student(string name, string surname, int age, int iqrank, int languagerank) : base(name, surname, age)
        {
           IQRank = iqrank;
            LanguageRank = languagerank;
        }
        public int Age
        {
            get
            { return Age; }
            set
            {
                if (value > 6&& value<20)
                {
                    Age = value;
                }
               
                
            }
        }
    }
}
