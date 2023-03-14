using System;
using System.Collections.Generic;
using System.Text;

namespace opp1
{
    public class Teacher
    {
        int id;
        string Name;
        string Subject;
        public virtual void Getdata()
        {
            Console.WriteLine("Please Enter The Staff Details");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter Id-");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name-");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Subject-");
            Subject = Console.ReadLine();

        }
        public virtual void Display()
        {
            Console.WriteLine("Id :" + id + "\nName :" + Name + "\nSubject :" + Subject);
        }

    }
}
