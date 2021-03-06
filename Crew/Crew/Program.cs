﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> l = new List<Worker>();
            l.Add(new Worker("Erat", WorkingPosition.director));
            l.Add(new Worker("Dasha", WorkingPosition.secretary));
            l.Add(new Worker("Aleksadr", WorkingPosition.cleaner));
            l.Add(new Worker("Pavel", WorkingPosition.bookkeper));
            l.Sort(new EqualityComparer());
            foreach (Worker w in l)
            {
                w.Write();
            }
            Console.WriteLine();
            Crew staff = new Crew();
            staff.Add(new Worker("Aleksadr", WorkingPosition.cleaner));
            staff.Add(new Worker("Pavel", WorkingPosition.bookkeper));
            staff.Insert(1, new Worker("Dasha", WorkingPosition.secretary));
            foreach (Worker w in staff)
            {
                w.Write();
            }

            if (staff.Contains(new Worker("Dasha", WorkingPosition.secretary)))
            {
                Console.WriteLine("Dasha is a member of staff");
            }
            else
            {
                Console.WriteLine("Dasha is not a member of staff");
            }
            staff.Remove(new Worker("Pavel", WorkingPosition.bookkeper));
            staff.RemoveAt(0);
            Console.WriteLine(staff.Count);

            Worker[] array = new Worker[50];
            staff.CopyTo(array, 0);

            foreach (Worker w in staff)
            {
                w.Write();
            }
            Console.WriteLine();
        }
    }
}
