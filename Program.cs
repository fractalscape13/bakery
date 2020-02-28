using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      string response = Products.Welcome();
      if (response == "bread" || response == "Bread")
      {
        Products.Bread.ChooseBread();
      }
      else if (response == "pastry" || response == "Pastry")
      {
        Products.Pastry.ChoosePastry();
      }
      else 
      {
        Products.Welcome();
      }
    }
  }
}