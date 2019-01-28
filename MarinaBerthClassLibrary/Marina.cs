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
        public static void mainMenu()
        {
            bool repeat = false;
            Console.WriteLine("WELCOME TO MARINA BERTH BOOKING SYSTEM.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Record a new booking.");
            Console.WriteLine("2. Delete a Booking.");
            Console.WriteLine("3. Display All Records.");//and available marina space
            Console.WriteLine("4. Exit Application.");
            Boat boat = new Boat();

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    do
                    {

                        boat.recordNewBooking();
                        Console.WriteLine("What do you want to do now?");
                        repeat = false;
                        //Console.WriteLine("Add another book? - Press 1.");
                        //Console.WriteLine("Go back to main menu? - Press any other button.");
                        //ConsoleKeyInfo keyPressed;
                        //keyPressed = Console.ReadKey();
                        //if (keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.NumPad1)
                        //{
                        //    repeat = true;
                        //    Console.Clear();
                        //}
                        //else
                        //{
                        //    repeat = false;
                        //}
                       
                    }
                    while (repeat == true);
                    Console.Clear();
                    mainMenu();
                    break;
                case "2":
                   boat.deleteBooking();
                    break;
                case "3":
                    boat.displayAllRecords();
                    break;
                case "4":
                    //exit;
                    break;
                 

            }
        }
    }
}
