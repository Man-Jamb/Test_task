using System;
using System.Collections;
using System.Collections.Generic;

namespace Circular
{
    public interface ICircularList<T> : IList<T>
    {
        void MoveNext();
        void MoveBack();
        T Current { get; }
        T Previous { get; }
        T Next { get; }
    }

    public class CircularList<T> : List<T>, ICircularList<T>
    {
        private int index = 0;

        public T Current => this[index];

        public T Previous => (index == 0) ? this[Count - 1] : this[index - 1];

        public T Next => (index == (Count - 1)) ? this[0] : this[index + 1];

        public void MoveBack()
        {
            if (index == 0)
            {
                index = Count - 1;
            }
            else
            {
                index--;
            }
        }

        public void MoveNext()
        {
            if (index == (Count - 1))
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
