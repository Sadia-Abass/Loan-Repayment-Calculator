internal class Program
{
    private static void Main(string[] args)
    {
        // Get loan details
        Console.WriteLine("Welcome!");
        Console.WriteLine("How much do you owe, in pound starlin?\n");
        double moneyOwed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the annual percetage rate of the loan?\n");
        double annualPercentageRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("How much would like to pay off each month in pound starlin?\n");
        double monthlyPayments = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("How many months do you want to see the result for?\n");
        int monthsToRepayLoan = Convert.ToInt32(Console.ReadLine());

        // Calculate monthly interest rate
        double monthly_rate = annualPercentageRate / 100 / 12;

        for(int i = 1; i <= monthsToRepayLoan; i++)
        {
            // Calculate interest to pay
            double interestPaid = moneyOwed * monthly_rate;

            // Add in interest
            moneyOwed += interestPaid;

            if(moneyOwed - monthlyPayments < 0)
            {
                Console.WriteLine($"The last payment is: {moneyOwed}");
                Console.WriteLine($"You paid off the loan in: {i + 1} months");
                break;
            }

            // Make payment
            moneyOwed -= monthlyPayments;

            Console.WriteLine($"Paid {monthlyPayments} of which {interestPaid} was interest Now you owe {moneyOwed} \n");         
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for using our loan calculator.");
        Console.ReadKey();
    }
}