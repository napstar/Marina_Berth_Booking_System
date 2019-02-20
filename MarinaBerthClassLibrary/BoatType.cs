using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
    public class BoatType
    {
        List<string> boatTypes = new List<string>();
        public  BoatType()
        {
            //Sailing, Motor, Narrow
            boatTypes.Add("Sailing");
            boatTypes.Add("Motor");
            boatTypes.Add("Narrow");
        }
        public string printBoatTypes()
        {
            StringBuilder sbRetVal = new StringBuilder ();
            for (int i = 0; i < boatTypes.Count; i++)
            {
                sbRetVal.AppendLine(i.ToString() + ". " + boatTypes.ElementAt(i));
            }
           

            return sbRetVal.ToString();
        }
    }
}
