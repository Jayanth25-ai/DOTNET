using System;

namespace StudentMarksReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Marks Report Generator ===");

            // Read number of subject for a students
            Console.Write("Enter total number of Subject for a Student : ");
            int n = int.Parse(Console.ReadLine());

            // Array to store marks
            int[] marks = new int[n];

            // It read marks of all Subject
            Console.WriteLine("Enter  each mark of a Subject:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Subject " + (i + 1) + " mark: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

           
            Console.WriteLine();
            Console.WriteLine("Marks (original order):");
            PrintArray(marks);

            //Backup copy of marks
            int[] backupMarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                backupMarks[i] = marks[i];
            }

            // Sorted copy of marks
            int[] sortedMarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortedMarks[i] = marks[i];
            }
            Array.Sort(sortedMarks);

            Console.WriteLine();
            Console.WriteLine("Marks (sorted order):");
            PrintArray(sortedMarks);

            // Total, highest, lowest marks of Student
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
            Console.WriteLine();

            // Average and Grade of Student
            double average = marks.Average();
            Console.WriteLine("Average mark: " + average);
            string grade;

            if (average >= 90)
            {
                grade = "A+";
            }
            else if (average >= 75)
            {
                grade = "A";
            }
            else if (average >= 60)
            {
                grade = "B";
            }
            else if (average >= 45)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine("Grade of a student: " + grade);

            // Search for a specific mark
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
                Console.WriteLine("The marks of another list of a student are also EQUAL.");
            }
            else
            {
                Console.WriteLine("The marks of another list of a student are not EQUAL.");
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
