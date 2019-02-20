using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
     public class BoatDataCapture
    {
        public int captureBoatLength()
        {
            int retVal = 0;

            return retVal;
        }
        public string captureBoatName()
        {
            string retVal = string.Empty;

            return retVal;
        }
        public string captureBoatOwner()
        {
            string retVal = string.Empty;

            return retVal;
        }
        public static Boat captureBoat()
        {
            Boat retVal = new MarinaBerthClassLibrary.Boat();
           
            string strBoatName = string.Empty;
            bool leave = false;
            while (true)
            {
                DisplayManager.clearScreen();
                //record a booking
                //
                DisplayManager.drawRectangle(" Please follow the Screen Instruction to enter Boat Details".ToUpper().PadLeft(60).PadRight(70) + string.Empty);
                Console.WriteLine("Enter Boat Name");
                strBoatName = DisplayManager.getUserInputStr();
                if (!string.IsNullOrEmpty(strBoatName))
                {
                    retVal.NameOfBoat = strBoatName;
                    break;
                }
                else
                {
                    //invalid input-chnage this to display manager later
                    
                   
                    bool visible = true;
                    string alert = visible ? "Warning!!!" : "";
                    visible = !visible;
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;


                    string details = "Please Enter a Valid Name".ToUpper();
                     
                    Console.WriteLine("{0}\n{1}", alert, details);
                    Console.ResetColor();
                    
                    while (string.IsNullOrEmpty( strBoatName=Console.ReadLine()))
                    {
                      
                        Console.WriteLine("{0}\n{1}", alert, details);
                        Console.WriteLine("If you wish to go back to the main menu\n Press Y\nIf you wish to continue\n Press N");
                        string data;
                        data = Console.ReadLine();
                        while (data.ToUpper() !="Y" && data.ToUpper() != "N")
                        {
                            Console.WriteLine("{0}\n{1}", "Warning", "Please enter a Y or N");
                            data = Console.ReadLine();
                        }
                        if ( data=="Y")
                        {
                            leave = true;
                           
                        }
                        break;
                    }
                    if (leave==true)
                    {
                        break;
                    }
                }
                
            }
            //if (leave==false)
            //{
            //    while (true)
            //    {
            //        string strBoatLength = "";
            //        Console.WriteLine("Enter Boat Length");
            //        while (string.IsNullOrEmpty(strBoatLength=Console.ReadLine()))
            //        {

            //            bool visible = true;
            //            string alert = visible ? "Warning!!!" : "";
            //            visible = !visible;

            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.White;


            //            string details = "Please Enter a Valid Boat Length".ToUpper();
            //            Console.WriteLine("{0}\n{1}", alert, details);
            //            Console.WriteLine("If you wish to go back to the main menu\n Press Y\nIf you wish to continue\n Press N");
            //            string data;
            //            if ((data = Console.ReadLine().ToUpper()) == "Y")
            //            {
            //                leave = true;

            //            }
            //            break;
            //        }
            //        if (leave)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            //validate boat lenght
            //            try
            //            {
            //                int boatLength = 0;
            //                int.TryParse(strBoatLength, out boatLength);
            //            }
            //            catch (Exception)
            //            {

                           
            //            }
            //        }
            //    }
                
            //    retVal.MaxLength = int.Parse(Console.ReadLine());
              
            //}
            //if (leave==false)
            //{
            //    Console.WriteLine("Enter Boat Owner");
            //    retVal.NameOfOwner = Console.ReadLine();
            //}
           

            return retVal;

        }
    }
}
