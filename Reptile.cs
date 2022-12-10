using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    public class Reptile : Animal
    {
        private Boolean _isPoisonous = false;
        private Boolean _isVenomous = false;
      

        private string[] LegalVenomousAnimals = {"HogNoseSnake","StingRay","Scorpion","GilaMonster" };
        private string[] LegalPoisonousAnimals = {"DartFrog","PurpleTreeTarantula","BlueRingOctopus"};

        //Maintenance level
        #region MaintLevel
        private string _MaintenanceLevel;
        public string MaintenanceLevel
        {
            get
            {
                return _MaintenanceLevel;
            }
            set
            {
                value = "Moderate";
                _MaintenanceLevel = value;              

            }
        }
        #endregion
        //Compare them to a list of common venom/poison pets and flag if it matches

        //Venomus Grumpy the Hognose
        #region isVenomousCheck
        public Boolean WarnIfVenomous(string SpeciesName)
        {
            Boolean isVenomous = _isVenomous;

            foreach(string v in LegalVenomousAnimals)
            {
                if(v == SpeciesName)
                {
                    isVenomous = true;
                }
            }

            return isVenomous;
        }
        #endregion

        #region IsPoisonousCheck
        //Poisonous Webs the Tarantula
        public Boolean WarnIfPoisonous(string SpeciesName)
        {
            Boolean isPoisonous = _isPoisonous;

            foreach (string v in LegalPoisonousAnimals)
            {
                if (v == SpeciesName)
                {
                    isPoisonous = true;
                }
            }

            return isPoisonous;
        }
        #endregion
    }

}
