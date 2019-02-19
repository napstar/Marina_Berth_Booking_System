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
            Queue QueueObj = new MarinaBerthClassLibrary.Queue();

            //Marina.mainMenu();
            bool check = true;
            int userInput = DisplayManager.displayHeaderMenu();
            while (userInput!=4)
            {
                if (check==false)
                {
                    userInput = DisplayManager.displayHeaderMenu();
                }
                
                

                Boat newBoat = new Boat();
                switch (userInput)
                {
                    case 1:
                        //clear 
                        DisplayManager.clearScreen();
                        //record a booking
                        check = false;
                        //use while loop here
                        newBoat = BoatDataCapture.Capture();
                        DisplayManager.ShowBoatCaptureMessage();
                        //add to queue
                      
                        QueueObj.Enqueue(newBoat);
                        DisplayManager.displayInvalidInputMessage("Do you wish to enter another boat?\n\n Please Enter Either 'Y' or 'N' to proceed");
                        string strProceed = DisplayManager.getUserInputStr();
                        while (strProceed.ToUpper() == "Y")
                        {
                            DisplayManager.clearScreen();
                            newBoat = BoatDataCapture.Capture();
                            QueueObj.Enqueue(newBoat);
                            DisplayManager.displayInvalidInputMessage("Do you wish to enter another boat?\n\n Please Enter Either 'Y' or 'N' to proceed");
                              strProceed = DisplayManager.getUserInputStr();
                        }
                        DisplayManager.displayInvalidMainMenuAndReturnToMainMenu("Going Back to Main Menu", 2000);
                        DisplayManager.clearScreen();
                      

                        break;
                    case 2:
                        check = false;
                        //Delete a Booking
                        break;
                    case 3:
                        check = false;
                        // display all
                       
                        Console.WriteLine(QueueObj.PrintElements());
                         strProceed = string.Empty;
                        DisplayManager.displayInvalidInputMessage("To go back to Main Menu\n Please Enter Either 'Y' or 'N' to proceed");
                        while (strProceed.ToUpper() == "N" ||strProceed.Equals(string.Empty))
                        {
                             strProceed = DisplayManager.getUserInputStr();
                            DisplayManager.clearScreen();
                            DisplayManager.displayInvalidInputMessage("To go back to Main Menu\n Please Enter Either 'Y' or 'N' to proceed");
                        }
                        DisplayManager.displayInvalidMainMenuAndReturnToMainMenu("Going Back to Main Menu", 2000);
                        DisplayManager.clearScreen();
                        break;
                    case 4:
                        check = false;
                        DisplayManager.exitApplication();
                        break;
                    default:
                        check = false;
                        //DisplayManager.displayInvalidInputMessage("Please Enter a valid menu option to proceed");
                        DisplayManager.clearScreen();
                        DisplayManager.displayInvalidMainMenuAndReturnToMainMenu("Invalid menu Option.Returning user back to MainMenu".ToUpper(),5000);
                        
                        DisplayManager.displayHeaderMenu();
                        break; 

                }
            }
          
           
            
               
        }
    }
}
