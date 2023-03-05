using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace DemoNet6
{
 

    internal class Program
    {
        static void Main(string[] args)

        {

            PhoneBook phoneBook = new PhoneBook(3);
            phoneBook.addNewNumber("basel", 5874, 0);
            phoneBook.addNewNumber("amjad", 5873, 1);
            phoneBook.addNewNumber("hema", 5872, 2);
            Console.WriteLine(phoneBook.GetNumber("basel"));
            phoneBook.setNumber("basel", 123);
            Console.WriteLine(phoneBook.GetNumber("basel"));

            phoneBook["amjad"] = 1234;//not error because use indexer
            Console.WriteLine(phoneBook.GetNumber("amjad"));

            Console.WriteLine(phoneBook[0]);
        }
    }
}
