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
            marks = new List<Mark> { new Mark("test0", new DateTime(1234567890), 0),
                                     new Mark("test1", new DateTime(1234567890), 1),
                                     new Mark("test2", new DateTime(1234567890), 2),
                                     new Mark("test3", new DateTime(1234567890), 3),
                                     new Mark("test4", new DateTime(1234567890), 4),
                                     new Mark("test5", new DateTime(1234567890), 5),
                                     new Mark("test6", new DateTime(1234567890), 6),
                                     new Mark("test7", new DateTime(1234567890), 7),
                                     new Mark("test8", new DateTime(1234567890), 8),
                                     new Mark("test9", new DateTime(1234567890), 9) };
            students = new List<Student> { new Student("test0", "test0", new DateTime(1234567890)),
                                           new Student("test1", "test1", new DateTime(1234567890)),
                                           new Student("test2", "test2", new DateTime(1234567890)),
                                           new Student("test3", "test3", new DateTime(1234567890)),
                                           new Student("test4", "test4", new DateTime(1234567890)),
                                           new Student("test5", "test5", new DateTime(1234567890)),
                                           new Student("test6", "test6", new DateTime(1234567890)),
                                           new Student("test7", "test7", new DateTime(1234567890)),
                                           new Student("test8", "test8", new DateTime(1234567890)),
                                           new Student("test9", "test9", new DateTime(1234567890)) };
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
