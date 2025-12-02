using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Credit Card Transaction Analyzer ===");
            Console.WriteLine();

            // Transaction ID → alphanumeric, 12 characters → string
            string transactionId = "TXN9A7B3C1D2";

            // Amount → up to ₹10,00,000.75 → decimal
            decimal amount = 457893.25m;

            // IsInternational → bool
            bool isInternational = false;

            // CustomerRating → 0.0 to 5.0 with decimal because it gives precision value(3.95),
            //if we use float or double it gives like (3.94999999).
            decimal customerRating = 3.95m;

            // TransactionTimestamp → DateTime
            DateTime transactionTimestamp = DateTime.Now

            // RewardPoints → whole number (millions) → int
            int rewardPoints = 1284500;

            // Display the values using string interpolation
            Console.WriteLine($"Transaction ID        : {transactionId}");
            Console.WriteLine($"Amount                : ₹{amount}");
            Console.WriteLine($"Is International      : {isInternational}");
            Console.WriteLine($"Customer Rating       : {customerRating}");
            Console.WriteLine($"Transaction Timestamp : {transactionTimestamp}");
            Console.WriteLine($"Reward Points         : {rewardPoints}");


            Console.WriteLine();
            Console.WriteLine("Running Temperature Module...");
            TemperatureModule.Start();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    class TemperatureModule
    {
        // Replaced the second Main() with Start()
        public static void Start()
        {
            Console.WriteLine("Temperature Module Running...");

            // Call helper
            VibrationModule.RunVibrationCheck();
        }
    }

    class VibrationModule
    {
        public static void RunVibrationCheck()
        {
            Console.WriteLine("Vibration Module Check Executed!");
        }
    }
}
