using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BoababRidge
{
    //This represents an animal receiving care at the rehab centre
    public class Animal
    {
        public string AnimalID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int Age { get; set; } 
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; } = "";

        //Method to calculate animal's status and housing unit from recovery score
        public void CalculateClassification()
        {
            if(RecoveryScore <= 19)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if(RecoveryScore <= 39)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if(RecoveryScore <= 59)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (RecoveryScore <= 79)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
        }

    }
}
