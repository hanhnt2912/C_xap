using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GenerateMenu();
        }
        private static List<Student> list = new List<Student>();
        private static void AddStudent()
        {
            while (true)
            {
                Student student = new Student();
                Console.WriteLine("vui long nhap ten:");
                student.Name = Console.ReadLine();
                Console.WriteLine("vui long nhap ten:");
                student.Rollnumber = Console.ReadLine();
                Console.WriteLine("vui long nhap email:");
                student.Email = Console.ReadLine();
                Console.WriteLine("vui long nhap so dien thoai:");
                student.Phone = Console.ReadLine();
                list.Add(student);
            }
        }

        private static void DisplayStudent()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.Name);
            }  
        }

        private static void SearchByName()
        {
            Console.WriteLine("vui long nhap ten sinh vien can tim:");
            var searchkey = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                if (student.Name  ==  searchkey)
                {
                    Console.WriteLine("Found:");
                    Console.WriteLine(student.Rollnumber + "-" + student.Name);
                }
            }
        }

        private static void GenerateMenu()
        {
            while (true)
            {
               Console.WriteLine("--------------Menu----------------"); 
                Console.WriteLine("1. Nhap cac sinh vien");
                Console.WriteLine("2. In ra cac sinh vien");
                Console.WriteLine("3. Tim sinh vien theo ten");
                Console.WriteLine("4. thoat");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Vui long nhap lua chon:");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                  case 1:
                      AddStudent();
                      break;
                  case 2:
                      DisplayStudent();
                      break;
                  case 3:
                      SearchByName();
                      break;
                  case 4:
                      Environment.Exit(1);
                      break;
                }

            }   
            
        }
    }
}