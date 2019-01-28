using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MarinaBerthClassLibrary
{
    public class Boat
    {
        private int maxLength;
        private int maxDraft;
        private string nameOfBoat, nameOfOwner;

        enum BoatType
        {
            Sailing,
            Motor,
            Narrow
            
        }
        public void recordNewBooking()
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

        public void deleteBooking()
        {
            throw new NotImplementedException();
        }

        public void displayAllRecords()
        {
            //and available marina space
            throw new NotImplementedException();
        }

        public void exitApplication()
        {
            throw new NotImplementedException();
        }
    }
}