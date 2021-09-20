using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Collection
    {
        public void diff()
        {
            ArrayList al = new ArrayList();
            al.Add(134);
            Console.WriteLine(al);

            Stack s = new Stack();
            s.Push(12);
            s.Push(2);
            s.Push(2141);
            s.Push(12);

            s.Pop();
            Console.WriteLine(s);
            Queue q = new Queue();
            q.Enqueue("sda");
            q.Enqueue("asdsa");

            q.Dequeue();


        }
        
    }
}
