using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class DonationTrackingSystem
    {
        static List<Donation> donations = new List<Donation>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nDonation & Aid Tracking System");
                Console.WriteLine("1. Add Donation");
                Console.WriteLine("2. View Donations");
                Console.WriteLine("3. Generate Report");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddDonation();
                        break;
                    case "2":
                        ViewDonations();
                        break;
                    case "3":
                        GenerateReport();
                        break;
                    case "4":
                        Console.WriteLine("Exiting... Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddDonation()
        {
            Console.Write("Enter donor name: ");
            string donor = Console.ReadLine();

            Console.Write("Enter donation amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
                return;
            }

            donations.Add(new Donation(donor, amount, DateTime.Now));
            Console.WriteLine("Donation added successfully.");
        }

        static void ViewDonations()
        {
            if (donations.Count == 0)
            {
                Console.WriteLine("No donations recorded yet.");
                return;
            }

            Console.WriteLine("\nDonation Records:");
            foreach (var donation in donations)
            {
                Console.WriteLine($"Donor: {donation.Donor}, Amount: ${donation.Amount}, Date: {donation.Date}");
            }
        }

        static void GenerateReport()
        {
            double totalAmount = 0;
            foreach (var donation in donations)
            {
                totalAmount += donation.Amount;
            }
            Console.WriteLine($"\nTotal Donations Collected: ${totalAmount}");
        }
    }

    class Donation
    {
        public string Donor { get; }
        public double Amount { get; }
        public DateTime Date { get; }

        public Donation(string donor, double amount, DateTime date)
        {
            Donor = donor;
            Amount = amount;
            Date = date;
        }
    }
}

