using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    internal class CustomLinkedList<T>
    {
        private Node<T> head;

        public CustomLinkedList() { 
        }

        public void AppendItem(T item)
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(item);
        }

        public void RemoveItem(string name)
        {
            PropertyInfo? propertyInfo = typeof(T).GetProperty("Name");

            if (propertyInfo != null)
            {
                Console.WriteLine("Item does not have 'Name' property");
            }
            else
            {
                Node<T> current = head;

            }

        }

        public bool FindItem(T item)
        {
            Node<T> current = head;

            if (current.Data != null)
            {
                do
                {
                    if (current.Data.Equals(item))
                    {
                        return true;
                    }
                    current = current.Next;
                } while (current.Next != null);
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
