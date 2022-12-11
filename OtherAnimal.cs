using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    internal class OtherAnimal : Animal
    {
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




    }
    
}
