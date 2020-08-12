using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace QueueCircularLinkedList
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;

            QueueCircularL quCL = new QueueCircularL();

            while(true)
            {
                Console.WriteLine("1.Queue Size");
                Console.WriteLine("2.Insert in Queue");
                Console.WriteLine("3.Delete from Queue");
                Console.WriteLine("4.Front Element in Queue");
                Console.WriteLine("5.Display all elements in Queue");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter Your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch(choice)
                {
                    case 1:
                        quCL.Size();
                        break;
                    case 2:
                        Console.WriteLine("Enter an element to insert in Queue: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        quCL.Insert(x);
                        break;
                    case 3:
                        Console.WriteLine("Deleted Element is: "+quCL.Delete());
                        break;
                    case 4:
                        Console.WriteLine("Front Element in Queue is: " + quCL.Peek());
                        break;
                    case 5:
                        quCL.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
