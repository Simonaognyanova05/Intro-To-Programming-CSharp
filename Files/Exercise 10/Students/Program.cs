namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            Student[] students = new Student[size];

            for (int i = 0; i < size; i++)
            {
                students[i] = new Student();
                Console.WriteLine($"Enter details for student {i + 1}:");
                students[i].FirstName = Console.ReadLine()!;
                students[i].LastName = Console.ReadLine()!;
                students[i].Grade = double.Parse(Console.ReadLine()!);
            }

            students = BubbleSortStudentArray(students);

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade}");
            }
        }

        private static Student[] BubbleSortStudentArray(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - i - 1; j++)
                {
                    if (students[j].Grade < students[j + 1].Grade)
                    {
                        Student tempStudent = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = tempStudent;
                    }
                }
            }

            return students;
        }
    }
}
