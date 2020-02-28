using System;
using System.Collections.Generic;
using Bakery.Models;
using System.Threading;

namespace Bakery
{
  public class Program
  {
    public static int totalCost = 0;
    public static List<string> allOrders = new List<string>(){};
    public static void Main()
    {
      string response = Products.Welcome();
      if (response == "bread" || response == "Bread")
      {
        string finalBreadOrder = Products.Bread.BreadOrder();
        allOrders.Add(finalBreadOrder);
        NextStep();
      }
      // else if (response == "pastry" || response == "Pastry")
      // {
      //   string finalPastryOrder = Products.Pastry.PastryOrder();
      //   FinalOrder(finalPastryOrder);
      // }
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

      public static void NextStep()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Products.TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
      Products.TypeLine("Would you like to proceed to checkout or add something else to your order? (choose checkout or add)");
      string nextStep = Console.ReadLine();
      if (nextStep == "checkout" || nextStep == "Checkout")
      {
        FinalOrder();
      }
      else if (nextStep == "add" || nextStep == "Add")
      {
        Console.Clear();
        Products.TypeLine("Bread or Pastry? (enter bread or pastry)");
        string nextOrder = Console.ReadLine();
        if (nextOrder == "bread" || nextOrder == "Bread")
        {
          string finalBreadOrder = Products.Bread.BreadOrder();
          allOrders.Add(finalBreadOrder);
          NextStep();
        }
        // else if (nextOrder == "pastry" || nextOrder == "Pastry")
        // {
        //   string finalPastryOrder = Products.Pastry.PastryOrder();
        //   allOrders.Add(finalPastryOrder);
        //   NextStep();
        // }
      }
      else
      {
        Console.Clear();
        Products.TypeLine("Something went wrong...");
        System.Threading.Thread.Sleep(4000);
        NextStep();
      }
    }
    public static void AddOrder()
    {
      Products.TypeLine("Would you like to checkou");
    }

    public static void FinalOrder()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Products.TypeLine("Your final order is:");
      foreach(string order in allOrders)
      {
        Products.TypeLine(order);
      }
      string totalStr = totalCost.ToString();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Products.TypeLine("Your order total is: $" + totalStr);
    }
  }
}