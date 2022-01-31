using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }
        public void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("Q - Quit");
        }
        public void PerformAction(string selection)
        {
            string name = "";
            string address = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    address = Console.ReadLine();
                    if (book.add(name, address))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", name);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    name = Console.ReadLine();
                    if (book.remove(name))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", name);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        book.list((a) => Console.WriteLine("{0} - {1}", a.name, a.address));
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    name = Console.ReadLine();
                    Address addr = book.find(name);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", name);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", name);
                    }
                    break;
            }
        }
    }
}
