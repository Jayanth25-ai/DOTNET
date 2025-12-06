using System;

namespace StudentMarksReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Marks Report Generator ===");

            // 1. Read number of students
            Console.Write("Enter number of Subject for a Student : ");
            int n = int.Parse(Console.ReadLine());

            // Array to store marks
            int[] marks = new int[n];

            // 2. Read marks of all Subject
            Console.WriteLine("Enter  each mark of a Subject:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Subject " + (i + 1) + " mark: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            // 3. Display original marks
            Console.WriteLine();
            Console.WriteLine("Marks (original order):");
            PrintArray(marks);

            // 4. Backup copy
            int[] backupMarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                backupMarks[i] = marks[i];
            }

            // 5. Sorted copy
            int[] sortedMarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortedMarks[i] = marks[i];
            }
            Array.Sort(sortedMarks);

            Console.WriteLine();
            Console.WriteLine("Marks (sorted order):");
            PrintArray(sortedMarks);

            // 6. Total, highest, lowest
            int totalMarks = 0;
            int highestMark = marks[0];
            int lowestMark = marks[0];

            for (int i = 0; i < n; i++)
            {
                totalMarks += marks[i];

                if (marks[i] > highestMark)
                {
                    highestMark = marks[i];
                }

                if (marks[i] < lowestMark)
                {
                    lowestMark = marks[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total no of marks : " + totalMarks);
            Console.WriteLine("Highest mark in a subject     : " + highestMark);
            Console.WriteLine("Lowest mark in a suject        : " + lowestMark);

            // 7. Search for a specific mark
            Console.WriteLine();
            Console.Write("Enter a mark to search: ");
            int searchMark = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (marks[i] == searchMark)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Mark " + searchMark + " is present in the list.");
            }
            else
            {
                Console.WriteLine("Mark " + searchMark + " is NOT present in the list.");
            }

            // 8. Show backup
            Console.WriteLine();
            Console.WriteLine("Backup copy of marks:");
            PrintArray(backupMarks);

            // 9. Compare with another set of marks
            Console.WriteLine();
            Console.WriteLine("Enter another set of marks to compare.");
            int[] otherMarks = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Student " + (i + 1) + " mark (other set): ");
                otherMarks[i] = int.Parse(Console.ReadLine());
            }

            bool arraysEqual = true;
            for (int i = 0; i < n; i++)
            {
                if (marks[i] != otherMarks[i])
                {
                    arraysEqual = false;
                    break;
                }
            }

            Console.WriteLine();
            if (arraysEqual)
            {
                Console.WriteLine("The marks of another lists of student are also EQUAL.");
            }
            else
            {
                Console.WriteLine("The marks of another lists of student are not EQUAL.");
            }

            Console.WriteLine();
            Console.WriteLine("Report completed. Press any key to exit...");
            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
