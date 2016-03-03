using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        private static int counter;
        private Node head;

        public LinkedList()
        {
        }

        public int getCount()
        {
            return counter;
        }


        public void Add(object data)
        {
            if (this.head == null)
            {
                this.head = new Node(data);
            }

            var tempNode = new Node(data);
            var currentNode = this.head;

            if (currentNode != null)
            {
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = tempNode;
            }

            counter++;
        }

        public bool Remove(int index)
        {
            if (index < 1 || index > counter)
            {
                return false;
            }

            var current = this.head;

            if (this.head != null)
            {
                for (int i = 0; i < index; i++)
                {
                    if (current.Next == null)
                    {
                        return false;
                    }

                    current = current.Next;
                }
                current.Next = current.Next.Next;
                counter--;
                return true;
            }
            return false;
        }

        public object Get(int index)
        {
            if (index <= 0)
            {
                return null;
            }

            if (this.head == null) return null;
            var currentNode = this.head.Next;

            for (var i = 0; i < index; i++)
            {
                if (currentNode.Next == null)
                {
                    return null;
                }

                currentNode = currentNode.Next;
            }

            return currentNode.Data;
        }

        public string toString()
        {
            var result = new StringBuilder();
            if (this.head != null)
            {
                var current = this.head.Next;

                while (current != null)
                {
                    var fragment = $"[ {current.Next} ]";
                    result.Append(fragment);
                    current = current.Next;
                }

            }
            return result.ToString();
        }
    }
}
