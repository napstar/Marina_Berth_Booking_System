using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarinaBerthClassLibrary;

namespace Marina_Berth_Booking_System
{
    class Program
    {
        static void Main(string[] args)
        {

            //Marina.mainMenu();
            int userInput = DisplayManager.displayHeaderMenu();
            while (userInput!=4)
            {
                bool check = true;


                Boat newBoat = new Boat();
                switch (userInput)
                {
                    case 1:
                        //record a booking
                        //use while loop here
                        newBoat = BoatDataCapture.Capture();
                        DisplayManager.ShowBoatCaptureMessage();
                        DisplayManager.displayInvalidInputMessage("Please Enter Either 'Y' or 'N' toproceed");
                        string strProceed = DisplayManager.getUserInputStr();

                        if (strProceed == "Y")
                        {
                           
                        }
                        else
                        {
                            DisplayManager.clearScreen();
                            DisplayManager.displayHeaderMenu();
                        }

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        DisplayManager.exitApplication();
                        break;
                    default:
                        //DisplayManager.displayInvalidInputMessage("Please Enter a valid menu option to proceed");
                        DisplayManager.displayInvalidMainMenuAndReturnToMainMenu("Invalid menu Option.Returning user back to MainMenu".ToUpper(),5000);
                        DisplayManager.clearScreen();
                        DisplayManager.displayHeaderMenu();
                        break; 

                }
            }
          
           
            
               
        }
    }
}
