using PetElevator.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    public class Customer : Person, IBillable
    {
        public string PhoneNumber { get; set; }
        public List<Pet> pets { get; set; } = new List<Pet>();

        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber= phoneNumber;
        }

        public Customer(string firstName, string lastName) : this(firstName, lastName, "")
        {
            
        }

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double  totalBalance = 0;
            foreach (KeyValuePair<string, double> kvp in servicesRendered)
            {
                totalBalance += kvp.Value;

            }
            return totalBalance;
        }


    }
}
