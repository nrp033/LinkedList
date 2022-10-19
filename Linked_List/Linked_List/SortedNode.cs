using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class SortedNode<T> : IComparable where T : IComparable<T>
    {
        

            public T data;
            public SortedNode<T> next;

            public SortedNode(T data)
            {
                this.data = data;
            }

            public int CompareTo(Object obj)
            {
            SortedNode<T> incomingNode = (SortedNode<T>)obj;
                return this.data.CompareTo(incomingNode.data);
            }


        
    }
}
