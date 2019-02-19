using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
     public class BoatDataCapture
    {
        public static Boat Capture()
        {
            Boat retVal = new MarinaBerthClassLibrary.Boat();
            Console.WriteLine("Record Boat");
            return retVal;
        }
    }
}
