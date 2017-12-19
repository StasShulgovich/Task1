using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Mark : IComparable<Mark>
    {
        public string LectureName { get; }
        public DateTime Date { get; }
        public int MarkNumber { get; }

        public Mark(string lectureName, DateTime date, int markNumber)
        {
            LectureName = lectureName;
            Date = date;
            MarkNumber = markNumber;
        }

        public int CompareTo(Mark other)
        {
            if (MarkNumber > other.MarkNumber)
            {
                return 1;
            }
            else if (MarkNumber < other.MarkNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
