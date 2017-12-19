using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        private List<Mark> marks = new List<Mark>();
        private string FirstName;
        private string LastName;
        private DateTime DOB;

        public Student(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
        }

        public void AddMark(Mark mark)
        {
            marks.Add(mark);
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            return (student == null) ? false : FirstName.Equals(student.FirstName) && LastName.Equals(student.LastName) && DOB.Equals(student.DOB);
        }

        public override int GetHashCode()
        {
            return (int)DOB.Ticks;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + marks.Select(x => x.MarkNumber).Max() + " " + marks.Select(x => x.MarkNumber).Min() + " " + marks.Select(x => x.MarkNumber).Sum() / marks.Count;
        }
    }
}
