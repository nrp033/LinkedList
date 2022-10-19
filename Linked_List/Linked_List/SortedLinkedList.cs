using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class SortedLinkedList
    {

        internal SortedNode<int> head;
        internal void Add(int data)
        {
            SortedNode<int> newNode = new SortedNode<int>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                SortedNode<int> temp = head;
                if (newNode.CompareTo(temp) < 0 || newNode.CompareTo(temp) == 0)
                {
                    head = newNode;
                    head.next = temp;
                }
                else
                {
                    if (temp.next == null)
                    {
                        temp.next = newNode;
                    }
                    else
                    {
                        while (temp.next != null)   //checks from start to the end of LinkedList
                        {
                            if (newNode.CompareTo(temp.next) > 0)   //if you write this in while condition, will give error in runtime for inserting largest number in last position
                            {
                                temp = temp.next;
                            }
                            else
                            {
                                break;  //without break, while loops for infinite times
                            }
                        }

                        if (temp.next != null)
                        {
                            newNode.next = temp.next;
                            temp.next = newNode;
                        }
                        else
                        {
                            temp.next = newNode;
                        }
                    }

                }

            }

        }

        internal void Display()
        {
            SortedNode<int> temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
