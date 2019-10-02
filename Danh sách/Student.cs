using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danhsach
{
    class Student
    {
        public string ten;
        public Student() { }
        public Student(string stName)
        {
            Name = stName;
        }
        protected string Name;
        public string StudentName
        {
            get
            { return Name; }
            set
            { Name = value; }
        }
        public virtual void Talk()
        {
            ten = Name;
        }
    }
}
