using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    internal class Rodent : Animal
    {

        #region Properties
        //Is Albino
        private Boolean _IsAlbino;
        public Boolean IsAlbino
        {
            get
            {
                return _IsAlbino;
            }
            set
            {
                _IsAlbino = value;

            }
        }

        //IsNoctournal
        private Boolean _IsNoctournal;
        public Boolean IsNoctournal
        {
            get
            {
                return _IsNoctournal;
            }
            set
            {
                _IsNoctournal = value;

            }
        }

        private string _SocialLevel = "Average";
        public string SocialLevel
        {
            get
            {
                return _SocialLevel;
            }
            set
            {
                _SocialLevel = value;

            }
        }
        #endregion

        public Boolean CanShareEnclosure(string SocialLevel)
        {
            Boolean CanShare = true;

            if (SocialLevel == "Aggressive")
            {
                CanShare = false;
            }



            return CanShare;
        }


    }
   
    
}
