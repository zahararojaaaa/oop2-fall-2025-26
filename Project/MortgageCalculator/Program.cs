using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       


       
        Console.Write("Enter Loan Amount: ");
        decimal P = decimal.Parse(Console.ReadLine());
       
       Console.Write("Enter Annual Interest Rate (in %): ");
       double annualRate = double.Parse(Console.ReadLine());
       
           Console.Write("Enter loan period ( in years): ");
           int years = int.Parse(Console.ReadLine());
        





        double r = annualRate / 100 / 12;  
        int n = years * 12;                
                   
        




        double numerator = r * Math.Pow(1 + r, n);
        double denominator = Math.Pow(1 + r, n) - 1;
         
        double monthlyPayment = (double)P * (numerator / denominator);
        decimal totalPaid = (decimal)monthlyPayment * n;
        decimal totalInterest = totalPaid - P;







        CultureInfo bdCulture = new CultureInfo("bn-BD");


        Console.WriteLine("\nMortgage Calculation Results");

        
      Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
     
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
     
        Console.WriteLine($"Total Interest:  {totalInterest.ToString("C", bdCulture)}");
        





    
      
    }
}

