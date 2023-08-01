using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Create a List for StudentName and perform following operations:
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index
//c. RemoveRange() -To Remove student with specified range.
//d. Clear() -To clear all the student from the list
namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            Console.WriteLine("Press 1 To Add");
            Console.WriteLine("Press 2 To Remove with specified index");
            Console.WriteLine("Press 3 To Remove with specified range.");
            Console.WriteLine("Press 4 To clear list");
            while (true)
            {
                Console.WriteLine("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name Of Student : ");
                        String name = Convert.ToString(Console.ReadLine());
                        list.Add(name);
                        printArrayList(list);
                        break;
                    case 2:
                        printArrayList(list);
                        Console.WriteLine("Enter Index To Remove Student : ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        list.RemoveAt(index);
                        printArrayList(list);
                        break;
                    case 3:
                        printArrayList(list);
                        Console.WriteLine("Enter Starting Range : ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Ending Range : ");
                        int end = Convert.ToInt32(Console.ReadLine());
                        list.RemoveRange(start, end);
                        printArrayList(list);
                        break;
                    case 4:
                        list.Clear();
                        printArrayList(list);
                        break;
                }
            }

        }
        static void printArrayList(List<String> list)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
