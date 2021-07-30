using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FQueue
{
    class MyQueue
    {
        public int length;
        public List<int> elem;

        private int First
        {
            get
            {
                if(elem.Count != 0)
                {
                    return elem.First();
                }
                else
                {
                    return 0;
                }
            }
        }
        private int Last
        {
            get
            {
                if (elem.Count != 0)
                {
                    return elem.Last();
                }
                else
                {
                    return 0;
                }
            }
        }
        public int Count => elem.Count();
        public MyQueue(int Length)
        {
            length = Length;
            elem = new List<int>(Length);
        }
        public void Push(int Element)
        {
            elem.Add(Element);
        }
        public int Pop()
        {
            if (length > 0)
            {
                var item = First;
                elem.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }

        public int Top()
        {
            if (length > 0)
            {
                return First;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }

        public void Enqueue(int Element)
        {
            elem.Insert(0, Element);
        }

        public void Clear()
        {
            if (length > 0)
            {
                elem.Clear();
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }
        public bool isEmpty()
        {
            if (elem != null)
            {
                return false;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }
       
        
        
    }
}
