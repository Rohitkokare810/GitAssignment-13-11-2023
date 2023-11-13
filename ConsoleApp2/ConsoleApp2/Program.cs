using System;

class SalaryCalculationSystem
{
    static void Main()
    {
        Console.WriteLine("Salary Calculation System");

        // Get employee type
        Console.WriteLine("Choose Employee Type:");
        Console.WriteLine("1. HR");
        Console.WriteLine("2. Admin");
        Console.WriteLine("3. Software Developer");

        int employeeType = int.Parse(Console.ReadLine());

        // Get input based on employee type
        int workingHours, numberOfWorkingDays, projectHandles, extras;
        Console.WriteLine("Enter working hours:");
        workingHours = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of working days:");
        numberOfWorkingDays = int.Parse(Console.ReadLine());

        switch (employeeType)
        {
            case 1: // HR
                projectHandles = 1;
                extras = 0;
                break;
            case 2: // Admin
                projectHandles = 0; // Admin has no project handles
                extras = 0;
                break;
            case 3: // Software Developer
                Console.WriteLine("Enter project handles:");
                projectHandles = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter extras:");
                extras = int.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Invalid Employee Type");
                return;
        }

        // Calculate and display the monthly salary
        double monthlySalary = CalculateMonthlySalary(workingHours, numberOfWorkingDays, projectHandles, extras);
        Console.WriteLine($"Monthly Salary: ${monthlySalary:F2}");
    }

    // Method to calculate monthly salary based on employee type
    static double CalculateMonthlySalary(int workingHours, int numberOfWorkingDays, int projectHandles, int extras)
    {
        double salary = workingHours * numberOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
        return salary;
    }
}
