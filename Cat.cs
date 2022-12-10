using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    internal class Cat : Animal
    {
        private Boolean _IsDeclawed;
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

        private Boolean _IsHouseTrained;
        public Boolean IsHouseTrained
        {
            get
            {
                return _IsHouseTrained;
            }
            set
            {
                _IsHouseTrained = value;
                //Log that the IsHouseTrained changed         
                AnimalFileList.Add(value.ToString());



            }
        }



    }


}
