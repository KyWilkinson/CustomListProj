using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {

        T[] _items;

        int _capacity;
        int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }


        public void Add(T item)
        {
            if (_count == _capacity)
            {
                _capacity *= 2;
                T[] temporaryArray = new T[_capacity];
                for (int i = 0; i < _count; i++)
                {
                    temporaryArray[i] = _items[i];

                }
                _items = temporaryArray;
            }


            _items[_count] = item;
            _count++;



        }
        //Additional remove tests: what happens if you remove a value not in the list? What about a value in the list more than once?
        public void Remove(T item)
        {
            //loop through entire array
            //conditional statement inside loop
            //if this is the item, what will we do? If this is not the item, what will we do?
        }
    }
}
