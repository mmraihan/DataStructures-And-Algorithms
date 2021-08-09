using System;

namespace StackUsingArray
{
    class StackArray
    {
        int[] data;
        int top;

        public StackArray( int n)
        {
            data = new int[n];
            top = 0;
        }

        public int length()
        {
            return top;
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public bool isFull()
        {
            return top == data.Length;
        }

        public void push (int e)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            else
            {
                data[top] = e;
                top = top + 1;
            }
        }


        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            int e = data[top - 1];
            top = top - 1;
            return e;

        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return data[top - 1];
        }


        public void display()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write(data[i] + "--");
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            StackArray s = new StackArray(10);
            s.push(5);
            s.push(4);
            s.display();
            Console.WriteLine("Size: " + s.length());
            Console.WriteLine("Element poped: "+ s.pop());
            
            Console.WriteLine("Is empty: " + s.isEmpty());
           

            Console.WriteLine("Element poped: " + s.pop());

            Console.WriteLine("Is empty: " + s.isEmpty());

            s.push(6);
            s.push(2);
            s.display();
            Console.WriteLine("Element top: " + s.peek());
            s.display();

        }
    }
}
