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
      TypeLineFast("▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫ ▫️");
      TypeLine("Bonjour et Bienvenue au Boulangerie de Pierre!");
      TypeLine("Bread or Pastry today? (enter bread or pastry)");
      string response = Console.ReadLine();
      return response;
    }

    public static void TypeLine(string input)
    {
      for (int i = 0; i < input.Length; i++)
      {
        Console.Write(input[i]);
        System.Threading.Thread.Sleep(30);
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
          return newBreadOrder.NextStep();
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
          return newBreadOrder.NextStep();
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
          return newBreadOrder.NextStep();
        }
        else
        {
          return "Sorry, we didn't catch that...";
        }
      }

      public string NextStep()
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
        TypeLine("Would you like to proceed to checkout or add pastries to your order? (choose checkout or add)");
        string nextStep = Console.ReadLine();
        if (nextStep == "checkout" || nextStep == "Checkout")
        {
          return FinalBreadOrder();
        }
        else if (nextStep == "add" || nextStep == "Add")
        {
          return "Find a way to order pastries";
        }
        else
        {
          return "";
        }
      }
      
      public string FinalBreadOrder()
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        if (Quantity > 1)
        {
          return "Your final order is " + Quantity + " loaves and your total cost is $" + Cost;
        }
        else if (Quantity == 1)
        {
            return "Your final order is " + Quantity + " loaf and your total cost is $" + Cost;
        }
        else
        {
          return "You didn't order anything";
        }
      }
    }

    public class Pastry
    {
      public static void PastryOrder()
      {
        TypeLine("Pastries then!");
      }
    }
  }
}