using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
    public class DisplayManager
    {
        public static int displayHeaderMenu()
        {
                string menuText =
                "\nWELCOME TO MARINA BERTH BOOKING SYSTEM.\n" +
                "What do you want to do?\n" +
                "1. Record a new booking.\n" +
                "2. Delete a Booking.\n" +
                "3. Display All Records.\n" +//and available marina space
                "4. Exit Application.";
            Console.WriteLine(menuText);
            int userInput = DisplayManager.getUserInput();
            return userInput;
        }

        public static void ShowBoatCaptureMessage()
        {
            string message = "\nYou are about to create a record for a Boat.\n press Y to continue or N or return to main menu";
            displayImportantMessage(message);
        }

        private static void displayImportantMessage(string  message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void clearScreen()
        {
            Console.Clear();
        }
        public static string getUserInputStr()
        {
           
            string retVal = Console.ReadLine();



            return retVal;
        }
        public static int getUserInput()
        {
            int retVal = -1;
            string strInput = Console.ReadLine();
            try
            {
                int.TryParse(strInput, out retVal);
            }
            catch (Exception ex)
            {
                string message = "Please enter an valid number";
                DisplayManager.displayInvalidInputMessage(message);
            }
            finally
            {

            }
           
            return retVal;
        }
        public static void exitApplication()
        {
            Environment.Exit(0);
        }
        public static void displayInvalidInputMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void displayMainMenu()
        {
            bool repeat = false;
            displayHeaderMenu();
             
            
            
        }

        public static void displayInvalidMainMenuAndReturnToMainMenu(string text, int milliseconds)
        {
            bool visible = true;
            string alert = visible ? "Warning!!!" : "";
            visible = !visible;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
           
            
            string details = text;
            Console.Write("{0}\n{1}", alert, details);
            System.Threading.Thread.Sleep(milliseconds);
            Console.ResetColor();
        }

        private enum MainMenuAction : int
        {
            invalid = 0,
            repeat = 1,

            newBooking = 1,
            deleteBooking = 2,
            displayAll=3,
            exit = 4,
        }
    }

 
}
