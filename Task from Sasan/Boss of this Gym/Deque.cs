using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_of_this_Gym
{
    class Deque:Stack
    {
        private int front;

        public Deque(int Lenght) : base(Lenght)
        {
            front = Lenght;
        }
        private bool CheckConflict()
        {
            return top == front - 1;
        }
        private bool CheckDEmpty()
        {
            return front >= items.Count;
        }
        private bool CheckDFull()
        {
            return front <= 0 || (top == -1 && front == 0) || (top == items.Count - 1 && front == items.Count);
        }


        public void pushBack(int TextIn) /*Добавление в начало дека*/
        {
            if (CheckConflict() || CheckDFull())
                throw new IndexOutOfRangeException();
            else
            {
                push(TextIn);
            }
        }

        public void popBack() /*Удаление из начала дека*/
        {
            pop();
        }

        public int getBack() /*Начальный элемент*/
        {
            return get();
        }

        public void pushFront(int TextIn)
        {
            if (CheckConflict() || CheckDFull())
                throw new IndexOutOfRangeException();
            else
            {
                items[--front] = TextIn;
            }
        }
        public void popFront()
        {
            if (CheckDEmpty())
                throw new IndexOutOfRangeException();
            else
            {
                items[front++] = 0;
            }
        }
        public int getFront()
        {
            if (CheckDEmpty())
                throw new IndexOutOfRangeException();
            else
                return items[front];
        }

        public int operations(string chose)
        {
            return stackOperations(chose);
        }

        public int[] getAll()
        {
            return all();
        }
        public void dequeReverse()
        {
            int t = front;
            front = items.Count - top - 1;
            top = items.Count - t - 1;
            stackReverse();
        }
        public int get_Front
        {
            get
            {
                return front;
            }
        }
        public int get_Back
        {
            get
            {
                return top;
            }
        }
    }
}
