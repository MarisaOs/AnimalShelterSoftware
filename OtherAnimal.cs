using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    internal class OtherAnimal : Animal
    {
        #region Properties
        private string _Species;
        public string Species
        {
            get
            {
                return _Species;
            }
            set
            {
                _Species = value;

            }
        }
        private string _Size;
        public string Size
        {
            get
            {
                return _Size;
            }
            set
            {
                _Size = value;

            }
        }
        #endregion

        #region Method

       

        public Boolean NeedPermitToOwn(string State, string AnimalSpecies)
        {
            
            Boolean NeedsPermit = false;
            string[] SpeciesThatNeedPermit = {"Fox","PrairieDog","Horse","Skunk","Python","Viper" };

            foreach (string s in SpeciesThatNeedPermit)
            {
                if (s == AnimalSpecies)
                {
                    NeedsPermit = true;
                   
                }
            }
            return NeedsPermit;
        }
        #endregion
        //PolyMorphic method
        #region OverrideMethod
        public override Boolean WarnIfPoisonous(string SpeciesName)
        {
            string[] LegalPoisonousAnimals = { "DartFrog", "PurpleTreeTarantula", "BlueRingOctopus", "Platypus", "Pufferfish" };
            Boolean isPoisonous = false;

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
