using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Address> addresses;
        public AddressBook()
        {
            addresses = new List<Address>();
        }
        public bool add(string name, string address)
        {
            Address adr = new Address(name, address);
            Address result = find(name);

            if (result == null)
            {
                addresses.Add(adr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool remove(string name)
        {
            Address addr = find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }

        public bool isEmpty()
        {
            return (addresses.Count == 0);
        }

        public Address find(string name)
        {
            Address adr = addresses.Find((a) => a.name == name);
            return adr;
        }
    }
}

