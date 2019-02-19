using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
    public class Node
    {
        public   Boat Data;
        public   Node Next;
        public  Node(Boat data)
        {
            Data = data;
        }
    }

    public class Queue
    {
        private Node _head;
        private Node _tail;
        private int _count = 0;
        public Queue()
        {
        }
        public void Enqueue(Boat data)
        {
            Node _newNode = new Node(data);
            if (_head == null)
            {
                _head = _newNode;
                _tail = _head;
            }
            else
            {
                _tail.Next = _newNode;
                _tail = _tail.Next;
            }
            _count++;
        }
        public Boat Dequeue()
        {
            Boat _result = new MarinaBerthClassLibrary.Boat();
            if (_head == null)
            {
                throw new Exception("Queue is Empty");
            }
             _result = _head.Data;
            _head = _head.Next;
            return _result;
        }
        public int Count
        {
            get
            {
                return this._count;
            }
        }

        public string PrintElements()
        {
            var node = _head;
            string[] elements = new string[_count];
            int i = 0;
            if (node!=null)
            {
                while (node != null)
                {
                    elements[i++] = node.Data.NameOfBoat;
                    node = node.Next;
                }
                return string.Join(" ", elements);
            }
            
            return ("No Data");
        }
    }
}
