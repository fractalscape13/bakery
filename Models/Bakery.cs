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
      TypeLine("Hello and welcome to le Bakery de Pierre!");
      TypeLine("Bread or Pastry today? (enter bread or pastry)");
      string response = Console.ReadLine();
      return response;
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
      public static void BreadOrder()
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
          Console.ForegroundColor = ConsoleColor.Cyan;
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          TypeLine("Would you like to proceed to checkout or add pastries to your order? (choose checkout or add)");
          string nextStep = Console.ReadLine();
          if (nextStep == "checkout" || nextStep == "Checkout")
          {
            newBreadOrder.FinalBreadOrder();
          }
          else if (nextStep == "add" || nextStep == "Add")
          {

          }
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
          Console.ForegroundColor = ConsoleColor.Cyan;
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          TypeLine("Would you like to proceed to checkout or add pastries to your order? (choose checkout or add)");
          string nextStep = Console.ReadLine();
          if (nextStep == "checkout" || nextStep == "Checkout")
          {
            newBreadOrder.FinalBreadOrder();
          }
          else if (nextStep == "add" || nextStep == "Add")
          {

          }

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
          Console.ForegroundColor = ConsoleColor.Cyan;
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️");
          TypeLine("Would you like to proceed to checkout or add pastries to your order? (choose checkout or add)");
          string nextStep = Console.ReadLine();
          if (nextStep == "checkout" || nextStep == "Checkout")
          {
            newBreadOrder.FinalBreadOrder();
          }
          else if (nextStep == "add" || nextStep == "Add")
          {

          }

        }
        else
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;
          TypeLine("Sorry, we didn't catch that...");
          System.Threading.Thread.Sleep(3000);
          BreadOrder();
        }
      }

      public void FinalBreadOrder()
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        if (Quantity > 1)
        {
          TypeLine("Your final order is " + Quantity + " loaves and your total cost is $" + Cost);
        }
        else if (Quantity == 1)
        {
            TypeLine("Your final order is " + Quantity + " loaf and your total cost is $" + Cost);
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
  }
}