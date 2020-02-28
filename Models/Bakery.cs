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
      TypeLineFast("▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️▫️" + Environment.NewLine);
      TypeLine("Hello and welcome to le Bakery de Pierre!" + Environment.NewLine);
      TypeLine("Bread or Pastry today?" + Environment.NewLine);
      string response = Console.ReadLine();
      return response;
    }
    
    public class Bread
    {
      public static void ChooseBread()
      {
        TypeLine("Yooo, time for bread y'all");
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