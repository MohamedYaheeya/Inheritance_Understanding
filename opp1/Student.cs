using System;
using System.Collections.Generic;
using System.Text;

namespace opp1
{
   public class Student:Teacher
    {
        int id;
        string Name;
        string Standard;
        public override void Getdata()
        {
            Console.WriteLine("Please Enter The Student Details");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter Id-");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name-");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Standard-");
            Standard = Console.ReadLine();

        }

        public new void Display()
        {
            Console.WriteLine("Id :" + id + "\nName :" + Name + "\nStandard :" + Standard);
        }
        
    }
}
