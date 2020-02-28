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
      TypeLineFast("▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫️ ▫ ▫️" + Environment.NewLine);
      TypeLine("Hello and welcome to le Bakery de Pierre!" + Environment.NewLine);
      TypeLine("Bread or Pastry today? (enter bread or pastry)" + Environment.NewLine);
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
      public static void BreadCost()
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Products.Bread newBreadOrder = new Products.Bread();
        TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️" + Environment.NewLine);
        TypeLine("Bread is $5 per loaf, or for multiple loaves it is buy 2, get 1 free." + Environment.NewLine);
        TypeLine("How many loaves of bread would you like to purchase?" + Environment.NewLine);
        TypeLine("A free loaf will be added to every 2 loaves purchased (please enter a whole number):" + Environment.NewLine);
        int quantity = int.Parse(Console.ReadLine());
        if (quantity == 1)
        {
          newBreadOrder.Cost = 5;
          newBreadOrder.Quantity = quantity;
          Console.Clear();
          TypeLine("The cost for " + newBreadOrder.Quantity + " loaf is $" + newBreadOrder.Cost);
        }
        else if (quantity > 1 && quantity % 2 == 0)
        {
          newBreadOrder.Cost = (quantity * 5);
          newBreadOrder.Quantity = quantity + (quantity / 2);
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️" + Environment.NewLine);
          TypeLine("The cost for " + newBreadOrder.Quantity + " loaves is $" + newBreadOrder.Cost + Environment.NewLine);
          TypeLine("(You are paying for " + quantity + " loaves and getting " + (quantity / 2) + " for free)" + Environment.NewLine);
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️" + Environment.NewLine);

        }
        else if (quantity > 1 && quantity % 2 != 0)
        {
          newBreadOrder.Cost = (quantity * 5);
          newBreadOrder.Quantity = quantity + ((quantity - 1) / 2);
          Console.Clear();
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️" + Environment.NewLine);
          TypeLine("The cost for " + newBreadOrder.Quantity + " loaves is $" + newBreadOrder.Cost + Environment.NewLine);
          TypeLine("(You are paying for " + quantity + " loaves and getting " + ((quantity - 1) / 2) + " for free!)" + Environment.NewLine);
          TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️" + Environment.NewLine);

        }
        else
        {
          TypeLine("Sorry, we didn't catch that");
          BreadCost();
        }
      }
    }

    public class Pastry
    {
      public static void ChoosePastry()
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
      }
      public static void TypeLineFast(string input)
      {
        for (int i = 0; i < input.Length; i++)
        {
          Console.Write(input[i]);
          System.Threading.Thread.Sleep(5);
        }
        Console.Write(Environment.NewLine);
      }
  }
}