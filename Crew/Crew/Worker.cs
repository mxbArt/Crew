using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    enum WorkingPosition{
        director = 4,
        secretary = 3,
        bookkeper = 2,
        cleaner = 1,
    }

    class Worker : IComparable<Worker>
    {
        private string _name;
        private WorkingPosition _wposition;

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

        public WorkingPosition WorkingPosition
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

        public Worker(string newName, WorkingPosition newPosition)
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
            return (left._name == right._name && left._wposition == right._wposition);
        }

        public static bool operator != (Worker left, Worker right)
        {
            return (left._name != right._name | left._wposition != right._wposition);
        }
    }

    class EqualityComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            return y.WorkingPosition.CompareTo(x.WorkingPosition);
        }
    }
}
