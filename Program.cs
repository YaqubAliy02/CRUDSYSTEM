using PhoneCrude.Models;
using PhoneCrude.Services;
using System.Linq.Expressions;

namespace PhoneCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PhoneBookService phoneBookService = new PhoneBookService();
            PhoneBook phoneBook = new PhoneBook();
            while (true)
            {

                PrintMenu();

                Console.Write("Enter your choice:");
                string userChoice = Console.ReadLine(); //Why I gave user's input with string format because if I give in int format when user enter string format like("fsdf") the program gives unhandiling exception 

                switch (userChoice)
                {
                    case "1":
                         phoneBook = new PhoneBook();
                        Console.Write("Enter name: ");
                        string nameOfItem = Console.ReadLine();
                        phoneBook.Name = nameOfItem;

                        Console.Write("Enter phoneNumber: ");
                        
                        string phoneNumberOfItem = Console.ReadLine();
                        phoneBook.PhoneNumber = phoneNumberOfItem;

                        phoneBookService.AddPhoneBook(phoneBook);

                        break;

                    case "2":

                        phoneBookService.ReadAllPhoneBook();

                        break;

                    case "3":

                        Console.WriteLine("Enter an id which you want to delete");
                        Console.Write("Enter id:");

                        string deleteWithIdStr = Console.ReadLine();
                        int deleteWithId = Convert.ToInt32(deleteWithIdStr);

                        phoneBookService.DeletePhoneBookById(deleteWithId);

                        break;

                    case "4":

                        Console.WriteLine("This function is not ready for working...");

                        break;

                        case "5":

                        Console.WriteLine("This function is not ready for working...");

                        break;

                    case "6":

                        ExitProgram();

                        break;

                    default:

                        Console.WriteLine("You entered wrong input, Try again ");
                        break;
                }
            }
        }
    

            public static void PrintMenu()
        {
            Console.WriteLine("1.CreatePhoneBooks");
            Console.WriteLine("2.DisplayAllPhoneBooks");
            Console.WriteLine("3.DeletePhoneBookById");
            Console.WriteLine("4.DisplayById");
            Console.WriteLine("5.Update");
            Console.WriteLine("6.Exit");
        }
        public static void ExitProgram()
        {
            Console.Write("Do you want to continue Yes\"y\" or No \"n\" ");
            char userChoice2 = Console.ReadLine()[0];
            if (userChoice2.Equals('n'))
            {
                Console.WriteLine("Thank you!!!!");
                Environment.Exit(0);
            }
        }
    }
}