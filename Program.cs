using System;
using System.Collections.Generic;
using Bakery.Models;
using System.Threading;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      string response = Products.Welcome();
      if (response == "bread" || response == "Bread")
      {
        Products.Bread.BreadOrder();
      }
      else if (response == "pastry" || response == "Pastry")
      {
        Products.Pastry newPastryOrder = new Products.Pastry();
        Products.Pastry.PastryOrder();
      }
      else 
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Products.TypeLine("We didn't catch that, sorry! Try again? (press enter to continue)");
        string tryAgain = Console.ReadLine();
        if (tryAgain != null)
        {
          Main();
        }
      }
    }
  }
}