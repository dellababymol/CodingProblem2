using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelLibrary
{
   public class ParcelType
    {
      public decimal _cost { get; set; }
      public string _type { get; set; }
      public ParcelType()
      {
          _cost = 0;
          _type = String.Empty;

      }
      
    }
}
