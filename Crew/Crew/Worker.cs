using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class Worker : IComparable<Worker>
    {
        private string _name;
        private string _wposition;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!value.Equals(null) && !value.Equals(""))
                {
                    _name = value;
                }
                else Console.WriteLine("Name is null or empty");
            }
        }

        public string WorkingPosition
        {
            get
            {
                return _wposition;
            }
            set
            {
                if (!value.Equals(null) && !value.Equals(""))
                {
                    _wposition = value;
                }
                else Console.WriteLine("Working position is null or empty");
            }
        }

        public Worker(string newName, string newPosition)
        {
            _name = newName;
            _wposition = newPosition;
        }

        public void Write()
        {
            Console.WriteLine("Name: " + _name + ", working position: " + _wposition);
        }

        public int CompareTo(Worker other)
        {
            return _name.CompareTo(other._name);
        }

       public static bool operator == (Worker left, Worker right)
        {
            return (left._name == right._name && left._name == right._name);
        }

        public static bool operator != (Worker left, Worker right)
        {
            return (left._name != right._name | left._name != right._name);
        }
    }

    class EqualityComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            if (x.WorkingPosition == null && y.WorkingPosition == null) return 0;
            else if (x.WorkingPosition == null) return -1;
            else if (y.WorkingPosition == null) return 1;
            else return x.WorkingPosition.CompareTo(y.WorkingPosition);
        }
    }
}
