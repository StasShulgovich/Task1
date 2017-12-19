using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        private static List<Mark> marks;
        private static List<Student> students;
        private static StudentGroup group;

        public static void Main(string[] args)
        {
            init();
            print();
            Console.ReadLine();
        }

        private static void init()
        {
            marks = new List<Mark> { new Mark("Math0", new DateTime(1234567890), 0),
                                     new Mark("Literature1", new DateTime(1234567890), 1),
                                     new Mark("Geography2", new DateTime(1234567890), 2),
                                     new Mark("Biology3", new DateTime(1234567890), 3),
                                     new Mark("Chemistry4", new DateTime(1234567890), 4),
                                     new Mark("Physics5", new DateTime(1234567890), 5),
                                     new Mark("Russhian6", new DateTime(1234567890), 6),
                                     new Mark("English7", new DateTime(1234567890), 7),
                                     new Mark("History8", new DateTime(1234567890), 8),
                                     new Mark("Music9", new DateTime(1234567890), 9) };
            students = new List<Student> { new Student("Name0", "LastName0", new DateTime(1234567890)),
                                           new Student("Name1", "LastName1", new DateTime(1234567890)),
                                           new Student("Name2", "LastName2", new DateTime(1234567890)),
                                           new Student("Name3", "LastName3", new DateTime(1234567890)),
                                           new Student("Name4", "LastName4", new DateTime(1234567890)),
                                           new Student("Name5", "LastName5", new DateTime(1234567890)),
                                           new Student("Name6", "LastName6", new DateTime(1234567890)),
                                           new Student("Name7", "LastName7", new DateTime(1234567890)),
                                           new Student("Name8", "LastName8", new DateTime(1234567890)),
                                           new Student("Name9", "LastName9", new DateTime(1234567890)) };
            group = new StudentGroup();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    students[i].AddMark(marks[Math.Abs(j - i)]);
                }
                group.Add(students[i]);
            }
        }

        private static void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(group[i].ToString());
            }
        }
    }
}
