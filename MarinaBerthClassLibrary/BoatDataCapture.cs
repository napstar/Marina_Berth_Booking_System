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
            Console.WriteLine("Enter Boat Name");
            retVal.NameOfBoat = Console.ReadLine();
            Console.WriteLine("Enter Boat Length");
           retVal.MaxLength =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter Boat Owner");
            retVal.NameOfOwner = Console.ReadLine();

            return retVal;
        }
    }
}
