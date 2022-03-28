using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2803
{
    class Group
    {
        public string No;
        public int StudentLimit;
        public Student[] Student; 

        public void  AddStudent(Student addedStudent)
        {
            if (Student.Length < StudentLimit)
            {
                Console.WriteLine("Sagirdin ad ve soyadini daxil edin:");
                string fullName = Console.ReadLine();
                addedStudent  = new Student(fullName);
                Array.Resize( ref Student, Student.Length + 1);
                Student[Student.Length-1] = addedStudent ;
             
            }
            foreach (var item in Student )
            {
                Console.WriteLine($"{item.GetInfo()}");
            }
            
        }
        public void GetInfo()
        {
            foreach (var item in Student )
            {
                Console.WriteLine($"ad ve soyad:{item.FullName} Qrup:{item.GroupNo} ortalama bal:{item.AvgPoint}");
            }
        }
    }
}
