using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Create an ArrayList for StudentName and perform following operations:
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index
//c. RemoveRange() -To Remove student with specified range.
//d. Clear() -To clear all the student from the list
namespace p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
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
                        arrayList.Add(name);
                        printArrayList(arrayList);
                        break;
                    case 2:
                        printArrayList(arrayList);
                        Console.WriteLine("Enter Index To Remove Student : ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        arrayList.RemoveAt(index);
                        printArrayList(arrayList);
                        break;
                    case 3:
                        printArrayList(arrayList);
                        Console.WriteLine("Enter Starting Range : ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Ending Range : ");
                        int end = Convert.ToInt32(Console.ReadLine());
                        arrayList.RemoveRange(start, end);
                        printArrayList(arrayList);
                        break;
                    case 4:
                        arrayList.Clear();
                        printArrayList(arrayList);
                        break;
                }
            }

        }
        static void printArrayList(ArrayList arrayList)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
