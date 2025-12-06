using System;

//This program can also be as the "Store Sales Trend Analysis" application. and
//STUDENTS MARKS GERNERATOR by changing the some senteces and variable names
//as SALES to MARKS and DAYS to STUDENTS as sales you enter the marks
//and can analyze total,highest and lowest marks of students in a class. 

namespace StoreSalesAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Store Sales Trend Analysis ===");                            

            // Enter number of days sales gone (size of array)
            Console.Write("Enter number of days in the month: "); // Enter number of students in the class
            int n = int.Parse(Console.ReadLine());

            // Create array to store sales  for each day
            int[] sales = new int[n];

            // Enter the sales value for each day
            Console.WriteLine("Enter sales for each day:");// Enter marks for each student
            for (int i = 0; i < n; i++)
            {
                Console.Write("Day " + (i + 1) + " sales: ");
                sales[i] = int.Parse(Console.ReadLine());
            }

            // Displays the original sales data
            Console.WriteLine();
            Console.WriteLine("Sales data (original order):");// Marks data (original order):
            PrintArray(sales);

            // It Creates a backup copy of the sales data
            int[] backupSales = new int[n];
            for (int i = 0; i < n; i++)
            {
                backupSales[i] = sales[i];
            }

            // Sorted copy of the sales data
            int[] sortedSales = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortedSales[i] = sales[i];
            }
            Array.Sort(sortedSales);

            Console.WriteLine();
            Console.WriteLine("Sales data (sorted order):");// Marks data (sorted order):
            PrintArray(sortedSales);

            // Find total, highest and lowest sales
            int totalSales = 0;
            int highestSales = sales[0];
            int lowestSales = sales[0];

            for (int i = 0; i < n; i++)
            {
                totalSales += sales[i];

                if (sales[i] > highestSales)
                {
                    highestSales = sales[i];
                }

                if (sales[i] < lowestSales)
                {
                    lowestSales = sales[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total sales for the month: " + totalSales);// Total marks for the class:
            Console.WriteLine("Highest sales in a  single-day: " + highestSales);// Highest marks of a student:
            Console.WriteLine("Lowest sales in a single-day : " + lowestSales);// Lowest marks of a  student:

            //Search for a particular sales value
            Console.WriteLine();
            Console.Write("Enter a sales value to search: ");// Enter a marks to search:
            int searchValue = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (sales[i] == searchValue)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Sales value " + searchValue + " is present in the data.");// The Mark
            }
            else
            {
                Console.WriteLine("Sales value " + searchValue + " is NOT present in the data.");
            }

            // Show that backup copy exists
            Console.WriteLine();
            Console.WriteLine("Backup copy of sales data (same as original):");// Backup copy of marks data (same as original):
            PrintArray(backupSales);

            // Compare original sales data with another set entered by the user
            Console.WriteLine();
            Console.WriteLine("Enter another set of sales data to compare.");// Enter another set of marks data to compare.
            int[] otherSales = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Day " + (i + 1) + " sales (other set): ");// DAY to  Student,Sales to Marks
                otherSales[i] = int.Parse(Console.ReadLine());
            }

            bool arraysEqual = true;
            for (int i = 0; i < n; i++)
            {
                if (sales[i] != otherSales[i])
                {
                    arraysEqual = false;
                    break;
                }
            }

            Console.WriteLine();
            if (arraysEqual)
            {
                Console.WriteLine("The original sales data and the other sales data are EQUAL.");//Sales to Marks
            }
            else
            {
                Console.WriteLine("The original sales data and the other sales data are NOT equal.");
            }

            Console.WriteLine();
            Console.WriteLine("Analysis completed. Press any key to exit...");
            Console.ReadKey();
        }

        // Helper method to print array values in a single line
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
