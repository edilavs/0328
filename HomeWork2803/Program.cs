using System;

namespace HomeWork2803
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qruplarin sayini daxil et:");
            int groupCount = Convert.ToInt32(Console.ReadLine());
            Group[] groups = new Group[groupCount];
            string no;
            int studentLimit;
            for (int i = 0; i < groupCount ; i++)
            {
                do
                {
                    Console.WriteLine($"{i + 1}.ci Qrupun nomresini daxil et:");
                    no = Console.ReadLine();
                }while ( char.IsUpper(no[0]) == false || char.IsUpper(no[1]) == false || char.IsDigit(no[2]) == false || char.IsDigit(no[3]) == false || char.IsDigit(no[4]) == false);
             
                do
                {
                    Console.WriteLine($"{i+1}.ci Qrupun telebe  sayi ucun limiti daxil edin:");
                    studentLimit = Convert.ToInt32(Console.ReadLine());
                } while (studentLimit < 0 || studentLimit > 20);

                groups[i] = new Group()
                {
                  No=no,
                  StudentLimit=studentLimit
                };
            }
            bool programIsWorking = true;
            do
            {


                Console.WriteLine("1.Telebe elave et \n 2.Butun telebelere bax \n 3.Telebeler üzrə axtarış et \n 0.Proqramı bitir\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Telebe elave et:");
                        Console.WriteLine("Telebenin ad ve soyadini daxil et:");
                        string fullName = Console.ReadLine();
                        Console.WriteLine("Telebenin qrup nomresini daxil et:");
                        string groupNo = Console.ReadLine();
                        Console.WriteLine("Telebenin ortalama balini daxil et:");
                        double avgPoint = Convert.ToDouble(Console.ReadLine());

                        Student addedStudent = new Student(fullName)
                        {
                            GroupNo = groupNo,
                            AvgPoint = avgPoint
                        };
                        Group.AddStudent(addedStudent);
                        break;

                    case 2:
                        Group.GetInfo();
                        break;
                    case 3:
                        Console.WriteLine("axtarilacaq sozu daxil et:");
                        break;
                    case 0:
                        programIsWorking = false;
                        break;
                    default:

                        programIsWorking = false;
                        break;
                }


                Console.WriteLine("Axtaris deyeri daxil et:");
                int value = Convert.ToInt32(Console.ReadLine());
            



                Console.WriteLine("Sagirdlerin sayini daxil et:");
                int count = Convert.ToInt32(Console.ReadLine());
                Student[] students = new Student[count];

                for (int i = 0; i < count; i++)
                {
                    string fullName;
                    Console.WriteLine($"{i + 1}.ci sagirdin ad ve soyadini daxil et:");
                    fullName = Console.ReadLine();

                    string groupNo;
                    Console.WriteLine($"{i + 1}.ci sagirdin qrup nomresini daxil edin:");
                    groupNo = Console.ReadLine();

                    double avgPoint;
                    Console.WriteLine($"{i + 1}.ci sagirdin ortalama balini daxil edin:");
                    avgPoint = Convert.ToDouble(Console.ReadLine());

                    students[i] = new Student(fullName)
                    {
                        GroupNo = groupNo,
                        AvgPoint = avgPoint,
                    };
                }
                foreach (var item in students)
                {
                    Console.WriteLine($"{item.GetInfo()}");
                }
            }while(programIsWorking)

             
           
            
        }
    }
}
