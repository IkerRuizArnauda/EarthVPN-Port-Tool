using System.Collections.Generic;

namespace EarthVPNDynamicPortTool
{
    public static class AvailableNetworks
   {
      //Network + Port prefix dictionary
      //In case of new networks just add them here with the proper first 2 digits prefix for the port.
      public static readonly Dictionary<string, string> Networks = new Dictionary<string, string>()
      {
         { "192.168.178" , "11" },
         { "192.168.179" , "10" }        
      };
   }
}
