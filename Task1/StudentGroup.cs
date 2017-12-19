using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class StudentGroup
    {
        private List<Student> students = new List<Student>();

        public Student this[int i]
        {
            get { return students[i]; }
            set { students[i] = value; }
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }
    }
}
