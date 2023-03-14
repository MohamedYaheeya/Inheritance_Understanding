using System;

namespace opp1
{
    class Program:Student
    {
        static void Main(string[] args)
        {
           
            Student student = new Student();
            student.Getdata();
            Console.WriteLine();
            student.Display();
            Teacher teacher = new Teacher();
            teacher.Getdata();
            Console.WriteLine();
            teacher.Display();
            
            
        }
      
    }
}
