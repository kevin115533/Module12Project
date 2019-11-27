using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12Solution
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private string address;
        private string state;
        private string city;
        private string zip;

        public Customer(string firstName, string lastName, string address, string city, string state, string zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.city = city;
            this.zip = zip;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address1 { get => address; set => address = value; }
        public string State { get => state; set => state = value; }
        public string City { get => city; set => city = value; }
        public string Zip { get => zip; set => zip = value; }
    }
}
