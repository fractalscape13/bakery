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
        Products.Bread.BreadCost();
      }
      else if (response == "pastry" || response == "Pastry")
      {
        Products.Pastry newPastryOrder = new Products.Pastry();
        Products.Pastry.ChoosePastry();
      }
      else 
      {
        Products.Welcome();
      }
    }
  }
}