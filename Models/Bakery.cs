using System;
using System.Collections.Generic;
using System.Threading;

namespace Bakery.Models
{
  public class Products
  {
    public static string Welcome()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      TypeLineFast("▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫ ▫️ ▫️ ▫ ▫️");
      TypeLine("Bonjour et Bienvenue au Boulangerie de Pierre!");
      TypeLine("Would you like to see our bread or pastry menu? (enter bread or pastry)");
      string response = Console.ReadLine();
      return response;
    }

    public static void TypeLine(string input)
    {
      for (int i = 0; i < input.Length; i++)
      {
        Console.Write(input[i]);
        System.Threading.Thread.Sleep(25);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
    }
    public static void TypeLineFast(string input)
    {
      for (int i = 0; i < input.Length; i++)
      {
        Console.Write(input[i]);
        System.Threading.Thread.Sleep(5);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
    }
    
    public class Bread
    {
      public int Cost { get; set; }
      public int Quantity { get; set; }
      
      public Bread()
      {
        Cost = 0;
        Quantity = 0;
      }
      public static string BreadOrder()
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Products.Bread newBreadOrder = new Products.Bread();
        TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
        TypeLine("Bread is $5 per loaf, & for multiple loaves it is buy 2, get 1 free.");
        TypeLine("How many loaves of bread would you like to purchase?");
        TypeLine("A free loaf will be added to every 2 loaves purchased (please enter a whole number):");
        int quantity = int.Parse(Console.ReadLine());
        if (quantity == 1)
        {
          newBreadOrder.Cost = 5;
          newBreadOrder.Quantity = quantity;
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          Console.ForegroundColor = ConsoleColor.Green;
          TypeLine("The cost for " + newBreadOrder.Quantity + " loaf is $" + newBreadOrder.Cost);
          Program.totalCost += newBreadOrder.Cost;
          return newBreadOrder.FinalBreadOrder();
        }
        else if (quantity > 1 && quantity % 2 == 0)
        {
          newBreadOrder.Cost = (quantity * 5);
          newBreadOrder.Quantity = quantity + (quantity / 2);
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          Console.ForegroundColor = ConsoleColor.Green;
          TypeLine("The cost for " + newBreadOrder.Quantity + " loaves is $" + newBreadOrder.Cost);
          TypeLine("(You are paying for " + quantity + " loaves and getting " + (quantity / 2) + " for free)");
          Program.totalCost += newBreadOrder.Cost;
          return newBreadOrder.FinalBreadOrder();
        }
        else if (quantity > 1 && quantity % 2 != 0)
        {
          newBreadOrder.Cost = (quantity * 5);
          newBreadOrder.Quantity = quantity + ((quantity - 1) / 2);
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          Console.ForegroundColor = ConsoleColor.Green;
          TypeLine("The cost for " + newBreadOrder.Quantity + " loaves is $" + newBreadOrder.Cost);
          TypeLine("(You are paying for " + quantity + " loaves and getting " + ((quantity - 1) / 2) + " for free!)");
          Program.totalCost += newBreadOrder.Cost;
          return newBreadOrder.FinalBreadOrder();
        }
        else
        {
          return "Sorry, we didn't catch that...";
        }
      }
      
      public string FinalBreadOrder()
      {
        Console.ForegroundColor = ConsoleColor.Green;
        if (Quantity > 1)
        {
          return Quantity + " loaves with a cost of $" + Cost;
        }
        else if (Quantity == 1)
        {
            return Quantity + " loaf with a cost of $" + Cost;
        }
        else
        {
          return "You didn't order anything";
        }
      }
    }

    public class Pastry
    {
      public int Cost { get; set; }
      public int Quantity { get; set; }
      
      public Pastry()
      {
        Cost = 0;
        Quantity = 0;
      }
      public static string PastryOrder()
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Products.Pastry newPastryOrder = new Products.Pastry();
        TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
        TypeLine("Pastries are $2 each, or get 3 for $5");
        TypeLine("How many total pastries would you like? (please enter a whole number)");
        int quantity = int.Parse(Console.ReadLine());
        if (quantity == 1)
        {
          newPastryOrder.Cost = 2;
          newPastryOrder.Quantity = quantity;
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          Console.ForegroundColor = ConsoleColor.Green;
          TypeLine("The cost for " + newPastryOrder.Quantity + " pastry is $" + newPastryOrder.Cost);
          Program.totalCost += newPastryOrder.Cost;
          return newPastryOrder.FinalPastryOrder();
        }
        else if (quantity > 1)
        {
          int divisor = quantity / 3;
          newPastryOrder.Cost = (quantity * 2) - divisor;
          newPastryOrder.Quantity = quantity;
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          Console.ForegroundColor = ConsoleColor.Green;
          TypeLine("The cost for " + newPastryOrder.Quantity + " pastries is $" + newPastryOrder.Cost);
          Program.totalCost += newPastryOrder.Cost;
          return newPastryOrder.FinalPastryOrder();
        }
        else
        {
          return "Sorry, we didn't catch that...";
        }      
      }
      public string FinalPastryOrder()
      {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        if (Quantity > 1)
        {
          return Quantity + " pastries with a cost of $" + Cost;
        }
        else if (Quantity == 1)
        {
            return Quantity + " pastry with a cost of $" + Cost;
        }
        else
        {
          return "You didn't order anything";
        }
      }
    }
  }
}