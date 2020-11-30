using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Node
    {
        //object description
        int Value;
        Node Previous, Next;


        //statics
        static Node Head, Tail;
        internal static void addInOrder(int v)
        {
            Node n = new Node();
            n.Value = v;
            if (Head == null)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                if (n.Value <= Head.Value)
                {
                    n.Next = Head;
                    Head.Previous = n;
                    Head = n;
                }
                else
                {
                    if (n.Value >= Tail.Value)
                    {
                        n.Next = Tail;
                        Tail.Next = n;
                        Tail = n;
                    }
                    else
                    {

                    }
                }
            }
        }

        internal static int[] getListAsArray()
        {
            return new int[0];
        }
    }
}
