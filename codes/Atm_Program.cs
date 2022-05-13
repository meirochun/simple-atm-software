using System;
using System.Globalization;

namespace Atm_Program
{
  public class ATM
  {
    static void Main(String[] args)
    {
      int amt = 10000, a, current, pin = 2003, pin1, pin2;

      // Read the PIN
      Console.Write("Enter the PIN: ");
      pin1 = int.Parse(Console.ReadLine());

      // Then compare the PIN
      if (pin1 == pin)
      {
        Console.WriteLine("1. To check the balance");
        Console.WriteLine("2. To withdraw money");
        Console.WriteLine("3. To deposite money");
        Console.WriteLine("4. To change the PIN");
        Console.WriteLine("Enter your choise");
        int ch = int.Parse(Console.ReadLine());
        
        switch(ch)
        {
          case 1:
            Console.WriteLine($"The current balance in your account is: {amt}");
            break;
          case 2:
            Console.WriteLine("Enter the amount to withdraw");
            {
              a = int.Parse(Console.ReadLine());
              if (amt >= a)
              {
                if (a%100 == 0)
                {
                  Console.WriteLine($"Please collect the cash {a}");
                  current = amt-a;
                  Console.WriteLine($"The current balance now is {current}");
                }
                else
                {
                  Console.WriteLine("Please enter the amount to withdraw in multiples of 100.");
                }
              }
            }
            break;

          case 3:
            Console.WriteLine("Enter the amount to deposite");
            a = int.Parse(Console.ReadLine());
            current = amt + a;
            Console.WriteLine($"The current balance now is {current}");
            break;
          
          case 4:
            Console.WriteLine("Wamt to change your PIN?");
            Console.WriteLine("Enter your previous PIN");
            int prepin = int.Parse(Console.ReadLine());
              
              if(prepin == pin)
              {
                Console.WriteLine("Enter your new PIN");
                pin2 = int.Parse(Console.ReadLine());
                pin1 = pin2;
                Console.WriteLine("Your PIN is changed");
              }
              else { Console.WriteLine("Enter your correct PIN"); }
              break;

            default:
              Console.WriteLine("Please select the correct option");
              break;
        }
      } else { Console.WriteLine("PIN is wrong."); }
    }
  }
}
