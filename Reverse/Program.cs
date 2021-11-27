using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> HudaLinkedList = new LinkedList<string>();

            LinkedListNode<string> HudaNode = HudaLinkedList.AddFirst("Maths");

            LinkedListNode<string> HudaNode2 = HudaLinkedList.AddLast("Physics");

            HudaLinkedList.AddBefore(HudaNode, "Mechanics");

            HudaLinkedList.AddAfter(HudaNode, "Robotics");

            HudaLinkedList.AddBefore(HudaNode2, "Chemistry");

            HudaLinkedList.AddAfter(HudaNode2, "Design");

            Console.WriteLine("The LinkedList Before Reversing: ");

            foreach (var item in HudaLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The LinkedList After Reversing: ");

            foreach (var item in HudaLinkedList.Reverse())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
