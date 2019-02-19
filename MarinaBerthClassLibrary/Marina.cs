using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
    public static  class Marina
    {
        private  static int getMarinaLength()
        {
            throw new NotImplementedException();
        }
        //public static void mainMenu_old()
        //{
        //    bool repeat = false;
        //    Console.WriteLine("WELCOME TO MARINA BERTH BOOKING SYSTEM.");
        //    Console.WriteLine("What do you want to do?");
        //    Console.WriteLine("1. Record a new booking.");
        //    Console.WriteLine("2. Delete a Booking.");
        //    Console.WriteLine("3. Display All Records.");//and available marina space
        //    Console.WriteLine("4. Exit Application.");
        //    Boat boat = new Boat();

        //    string userChoice = Console.ReadLine();
        //    switch (userChoice)
        //    {
        //        case "1":
        //            do
        //            {

        //                boat.recordNewBooking();
        //                Console.WriteLine("What do you want to do now?");
        //                repeat = false;
        //                //Console.WriteLine("Add another book? - Press 1.");
        //                //Console.WriteLine("Go back to main menu? - Press any other button.");
        //                //ConsoleKeyInfo keyPressed;
        //                //keyPressed = Console.ReadKey();
        //                //if (keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.NumPad1)
        //                //{
        //                //    repeat = true;
        //                //    Console.Clear();
        //                //}
        //                //else
        //                //{
        //                //    repeat = false;
        //                //}
                       
        //            }
        //            while (repeat == true);
        //            Console.Clear();
        //            mainMenu();
        //            break;
        //        case "2":
        //           boat.deleteBooking();
        //            break;
        //        case "3":
        //            boat.displayAllRecords();
        //            break;
        //        case "4":
        //            //exit;
        //            break;
                 

        //    }
        //}

        public static void recordNewBooking()
        {
            try
            {
                Boolean check = true;
                Console.WriteLine("Type Exit to go back to Main Menu");
                //do
                //{
                while (!Console.KeyAvailable && check)
                {


                    Console.WriteLine("Enter The Name Of the Boat?");
                    string boatName = Console.ReadLine();

                    if (boatName.ToUpper().Equals("EXIT"))
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Boat Name: " + boatName);
                    }
                    Console.WriteLine("Enter The Length Of the Boat?");
                    string strLen = Console.ReadLine();
                    if (strLen.ToUpper().Equals("EXIT"))
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Boat Draft: {0}", strLen);
                    }
                    Console.WriteLine("Enter The Draft Of the Boat?");
                    string strDraft = Console.ReadLine();
                    if (strDraft.ToUpper().Equals("EXIT"))
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Boat Draft: {0}", strDraft);
                    }
                    //no more erros
                    if (check)
                    {
                        Boat currentBoat = new Boat();
                        currentBoat.MaxDraft = int.Parse(strDraft);
                        currentBoat.MaxLength = int.Parse(strLen);
                    }
                    



                }

                //Console.WriteLine("Type Exit to go back to Main Menu");

                //Console.WriteLine("Enter The Name Of the Boat?");
                //string boatName = Console.ReadLine();
                //if (boatName.ToUpper().Equals("EXIT"))
                //{
                //    break;
                //}
                //Console.WriteLine("Boat Name: " + boatName);
                //Console.WriteLine("Enter The Length Of the Boat?");
                //string strLen = Console.ReadLine();
                //Console.WriteLine("Boat Draft: {0}", strLen);
                ////validate boat length here
                //Console.WriteLine("Enter The Draft Of the Boat?");
                //string strDraft = Console.ReadLine();

                //Console.WriteLine("Boat Draft: {0}", strDraft);
                // } while (Console.ReadKey(true).Key !=ConsoleKey.Escape);








            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void deleteBooking()
        {
            throw new NotImplementedException();
        }

        public static void displayAllRecords()
        {
            //and available marina space
            throw new NotImplementedException();
        }
    }
}
