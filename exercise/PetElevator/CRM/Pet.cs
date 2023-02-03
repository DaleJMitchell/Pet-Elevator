using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    public class Pet
    {
        public string PetName { get; set; }
        public string Species { get; set; }
        public List<string> Vaccinations { get; set; } = new List<string>();

        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;
        }

        public string ListVaccinations()
        {
            return string.Join(", ", Vaccinations);
        }


    }
}
