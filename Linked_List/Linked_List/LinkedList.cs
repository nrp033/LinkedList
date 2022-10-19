using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class LinkedList
    {
        internal Node head;
        internal void AddReverse(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        internal void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Insert(int position, int data)
        {
            Node newNode = new Node(data);

            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                Node temp = head;
                newNode.next = temp;
                head = newNode;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp.next != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp.next != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.WriteLine("Node at (position - 1) is null");
                }
            }
        }
        public void Pop()
        {
            if (head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;
                temp = null;
            }
            else
            {
                Console.WriteLine("LinkedList is empty");
            }
        }
        public void PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }

            Node newnode = head;

            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            Node popLast = newnode.next;
            newnode.next = null;
        }

        internal int SearchNode(int data)
        {
            int Position = 1;
            if (head != null)
            {
                Node temp = head;
                while (temp.data != data)
                {
                    Position++;
                    temp = temp.next;
                }
                Console.WriteLine("\nNode with Key "+ data+" is at position: "+ Position);
            }
            else
            {
                Console.WriteLine("Linked List is Empty !");
            }
            return Position;
        }



        public void Display()
            {
                Node temp = head;
                if (temp == null)
                {
                    Console.WriteLine("LinkedList is empty");
                    return;
                }
                else
                {
                    while (temp != null)
                    {
                        Console.Write(temp.data + "  ");
                        temp = temp.next;
                    }
                }
            }
        }
    }


