using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smart Electricity Billing & Summary System (EnergyTech)");
        Console.WriteLine("-------------------------------------------");

        // Input number of consumers
        Console.Write("Enter number of consumers (N): ");
        int n = int.Parse(Console.ReadLine());

        int totalConsumers = 0;
        double totalRevenue = 0.0;
        double highestBill = 0.0;
        string highestBillConsumerId = "";

        int domesticCount = 0;
        int commercialCount = 0;
        //For Each Consumer Enter Details
        Console.WriteLine();
        Console.WriteLine("Enter details in this format: ConsumerID UnitsConsumed ConnectionType");
        Console.WriteLine ("Example:customer id= C001 units cons 120 connection type= 1");
        Console.WriteLine("ConnectionType: 1 = Domestic, 2 = Commercial");

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Consumer #" + (i + 1));

            // Example: C001 120 1
            Console.Write("Enter ConsumerID, UnitsConsumed, ConnectionType: ");
            string line = Console.ReadLine();

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string consumerId = parts[0];
            int units = int.Parse(parts[1]);
            int type = int.Parse(parts[2]);

            string typeName;
            if (type == 1)
            {
                typeName = "Domestic";
                domesticCount++;
            }
            else
            {
                typeName = "Commercial";
                commercialCount++;
            }

            // Calculate base charge (simple band-wise rate, NOT slab-wise)
            double rate = 0.0;
            double baseCharge = 0.0;

            if (type == 1) // Domestic
            {
                if (units >= 0 && units <= 100)
                {
                    rate = 1.50;
                }
                else if (units >= 101 && units <= 300)
                {
                    rate = 2.50;
                }
                else // > 300
                {
                    rate = 4.00;
                }
            }
            else if (type == 2) // Commercial
            {
                if (units >= 0 && units <= 200)
                {
                    rate = 5.00;
                }
                else if (units >= 201 && units <= 500)
                {
                    rate = 6.50;
                }
                else // > 500
                {
                    rate = 8.00;
                }
            }

            baseCharge = units * rate;

            // Environmental surcharge = 3% of base charge
            double surcharge = baseCharge * 0.03;

            // Penalty if units > 500
            double penalty = 0.0;
            if (units > 500)
            {
                penalty = 200.0;
            }

            double total = baseCharge + surcharge + penalty;

            // Discount 5% if total > 2000
            double discount = 0.0;
            if (total > 2000.0)
            {
                discount = total * 0.05;
            }

            double finalBill = total - discount;

            // Print details (more human style)
            Console.WriteLine();
            Console.WriteLine("ConsumerID : " + consumerId);
            Console.WriteLine("Type       : " + typeName);
            Console.WriteLine("Units      : " + units);
            Console.WriteLine("Base       : " + rate.ToString("0.00") + " * " + units + " = " + baseCharge.ToString("0.00"));
            Console.WriteLine("Surcharge  : " + surcharge.ToString("0.00"));
            Console.WriteLine("Penalty    : " + penalty.ToString("0.00"));
            Console.WriteLine("Discount   : " + discount.ToString("0.00"));
            Console.WriteLine("Final Bill : " + finalBill.ToString("0.00"));
            Console.WriteLine("-------------------------------------------");

            // Update summary
            totalConsumers++;
            totalRevenue += finalBill;

            if (finalBill > highestBill)
            {
                highestBill = finalBill;
                highestBillConsumerId = consumerId;
            }
        }

        // Summary section
        Console.WriteLine();
        Console.WriteLine("=========== SUMMARY ===========");
        Console.WriteLine("Total Consumers : " + totalConsumers);
        Console.WriteLine("Total Revenue   : " + totalRevenue.ToString("0.00"));
        Console.WriteLine("Highest Bill    : " + highestBillConsumerId + " -> " + highestBill.ToString("0.00"));
        Console.WriteLine("Domestic Count  : " + domesticCount);
        Console.WriteLine("Commercial Count: " + commercialCount);
        Console.WriteLine("================================");

        Console.WriteLine("End of report. Press any key to exit.");
        Console.ReadKey();
    }
}
