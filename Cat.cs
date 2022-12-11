using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    internal class Cat : Animal
    {

        #region Properties
        private Boolean _IsDeclawed = true;
        public Boolean IsDeclawed
        {
            get
            {
                return _IsDeclawed;
            }
            set
            {
                _IsDeclawed = value;
                //Log that the IsDeclawed changed         
                AnimalFileList.Add(value.ToString());

                

            }
        }

        private Boolean _IsLitterTrained = true;
        public Boolean IsLitterTrained
        {
            get
            {
                return _IsLitterTrained;
            }
            set
            {
                _IsLitterTrained = value;
                //Log that the IsLitterTrained changed         
                AnimalFileList.Add(value.ToString());



            }
        }
        #endregion

        public Boolean IsHouseTrained(Boolean IsDeclawed, Boolean IsLitterTrained)
        {
            Boolean HouseTrained = false;

            if (IsDeclawed && IsLitterTrained)
            {
                HouseTrained = true;
            }



            return HouseTrained;
        }





    }


}
