﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    public class Animal
    {
        //Private information
        private string PreviousOwnerInfo;
    
        public Animal()
        {
            

        }

        //Encapsulation of private variables to the field.



        //List to send to file
        private List<string> _AnimalFileList;
        public List<string> AnimalFileList
        {
            get { return _AnimalFileList; }
            set { _AnimalFileList = value; }
        }
        //Fields
        #region Name
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                //Log that the name changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        #region Breed
        private string _Breed;
        public string Breed
        {
            get
            {
                return _Breed;
            }
            set
            {
                _Breed = value;
                //Log that the Breed changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        #region Age
        private string _Age;
        public string Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
                //Log that the Age changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        #region Appearance
        private string _Appearance;
        public string Appearance
        {
            get
            {
                return _Appearance;
            }
            set
            {
                _Appearance = value;
                //Log that the Appearance changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        #region EnteredShelterDate
        private string _EnteredShelterDate;
        public string EnteredShelterDate
        {
            get
            {
                return _EnteredShelterDate;
            }
            set
            {
                _EnteredShelterDate = value;
                //Log that the EnteredShelterDate changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        #region AdoptionDate
        private string _AdoptionDate;
        public string AdoptionDate
        {
            get
            {
                return _AdoptionDate;
            }
            set
            {
                _AdoptionDate = value;
                //Log that the AdoptionDate changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        #region ExtraInfo
        private string _ExtraInformation;
        public string ExtraInformation
        {
            get
            {
                return _ExtraInformation;
            }
            set
            {
                _ExtraInformation = value;
                //Log that the ExtraInformation changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        //Method
        //Fill List with information from the file.
        public void SaveAnimalToFile(string AnimalFilePath)
        {
            string AnimalInfoFormated = Name + " " + Breed + " " + Age + " " + Appearance + " " + EnteredShelterDate + " " + AdoptionDate + " ~" + ExtraInformation;
            File.AppendAllText(AnimalFilePath,AnimalInfoFormated);
        }


    }
}
