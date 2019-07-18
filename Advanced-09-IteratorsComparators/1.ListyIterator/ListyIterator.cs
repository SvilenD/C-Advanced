namespace P01_ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T>
    {
        private List<T> list;

        private int index;

        public void Create(params T[] items)
        {
            this.list = new List<T>(items);
            //this.index = 0;
        }

        public bool HasNext()
        {
            if (list.Count < index - 1)
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public void Print()
        {

        }
    }
}
