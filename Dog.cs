using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    internal class Dog : Animal
    {
        private Boolean _IsSpayedOrNeutered;
        public Boolean IsSpayedOrNeutered
        {
            get
            {
                return _IsSpayedOrNeutered;
            }
            set
            {
                _IsSpayedOrNeutered = value;

            }
        }

        private Boolean _IsPottyTrained;
        public Boolean IsPottyTrained
        {
            get
            {
                return _IsPottyTrained;
            }
            set
            {
                _IsPottyTrained = value;

            }
        }




        public Boolean ValidateVaccinations(string DogName, string[] CurrentVaccinations)
        {
            Boolean VaccinationsUTD = true;
           

            foreach(string c in CurrentVaccinations)
            {
                if (c != "Parvovirus" || c!="Distemper" || c!="Hepatitis" || c!="Rabies")
                {
                    VaccinationsUTD = false;
                }
            }



            return VaccinationsUTD;
        }


    }

    
    
}
