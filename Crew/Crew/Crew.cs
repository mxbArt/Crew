using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class Crew : IList<Worker>
    {
        private Worker[] _workers = new Worker[50];
        private int _count;

        public Crew()
        {
            _count = 0;
        }

        public Worker this[int index]
        {
            get
            {
                return _workers[index];
            }

            set
            {
                _workers[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Worker item)
        {
            if (_count < _workers.Length)
            {
                _workers[_count] = item;
                _count++;
            }
            else Console.WriteLine("Crew is full");
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(Worker item)
        {
            bool inList = false;
            for (int i = 0; i < _workers.Length; i++)
            {
                if (_workers[i] == item)
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public void CopyTo(Worker[] array, int arrayIndex)
        {
            for (int i = 0; i < _count; i++)
            {
                array.SetValue(_workers[i], arrayIndex);
                arrayIndex++;
            }
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _workers[i];
            }
        }

        public int IndexOf(Worker item)
        {
            int itemIndex = -1;
            for (int i = 0; i < _count; i++)
            {
                if (item == _workers[i])
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, Worker item)
        {
            if ((_count + 1 <= _workers.Length) && (index <= _count) && (index >= 0))
            {
                _count++;

                for (int i = _count - 1; i > index; i--)
                {
                    _workers[i] = _workers[i - 1];
                }
               _workers[index] = item;
            }
        }

        public bool Remove(Worker item)
        {
            if (Contains(item))
            {
                int ind = IndexOf(item);
                for (int i = ind; i < _count - 1; i++)
                {
                    _workers[i] = _workers[i + 1];
                }
                _count--;
                return true;
            }
            else return false;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < _count))
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _workers[i] = _workers[i + 1];
                }
                _count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
