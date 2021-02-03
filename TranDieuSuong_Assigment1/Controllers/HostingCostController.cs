using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDieuSuong_Assigment1.Controllers
{
  public class HostingCostController : ApiController
  {

    //Get api/HostingCost/5
    /// <summary>
    /// Calculating the total hosting cost of the client per fortnight with tax included
    /// then print the full information of the cost
    /// </summary>
    /// <param name="id">the days the client has stayed</param>
    /// <returns>3 strings that describe the hosting cost</returns>
    /// <example>
    /// Get api/hostingcost/5 ---> "2 fortnights at $5.50/FN = $11.00 CAD"
    ///                            "HST 13% = $1.43 CAD</string>"
    ///                            "Total = $12.43 CAD"
    /// </example>
    public IEnumerable<string> Get(int id)
    {
      decimal rate = 5.50M;
      decimal taxRate = 0.13M;
      int FortN = (id / 14) + 1; // ex: 15/14 + 1 = 1 + 1 = 2 FNights
      decimal total = FortN * rate;
      decimal tax = total * taxRate;
      decimal afterTax = total + tax;

      return new string[] { $"{FortN} fortnights at ${rate.ToString("F")}/FN = ${total.ToString("F")} CAD",
        $"HST {taxRate * 100}% = ${tax.ToString("F")} CAD",
        $"Total = ${afterTax.ToString("F")} CAD" };

    }

  }
}
