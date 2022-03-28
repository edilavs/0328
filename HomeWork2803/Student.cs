using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2803
{
    class Student
    {
        public Student(string fullname)
        {
            this.FullName = fullname;
        }
        public string FullName;
        public string GroupNo;
        public double AvgPoint;

        public string GetInfo()
        {
            return $"Ad ve soyad: {FullName} Qrup nomresi:{GroupNo} Ortamala bal:{AvgPoint }";
        }

    }
}
