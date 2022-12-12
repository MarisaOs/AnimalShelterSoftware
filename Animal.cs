using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterSoftware
{
    public abstract class Animal
    {
        //Private information
        private string PreviousOwnerInfo = "Redacted";

        #region Constructors

        //Overloaded constructors
        public Animal()
        {
            

        }

        public Animal(string[] FileLine)
        {

        }
        #endregion

        //Animal List for events
        private List<string> _AnimalFileList;
        public List<string> AnimalFileList
        {
            get { return _AnimalFileList; }
            set { _AnimalFileList = value; }
        }
        //Properties
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

        #region Gender
        private string _Gender;
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
                //Log that the Gender changed         
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
                //Data hiding
                if (PreviousOwnerInfo != "Redacted")
                {
                    value = value + PreviousOwnerInfo;
                }
                _ExtraInformation = value;
                //Log that the ExtraInformation changed         
                AnimalFileList.Add(value);

            }
        }
        #endregion

        //Method
        //Save information in the fields to the file
        #region FileSaves
        public void SaveAnimalToFile(string AnimalFilePath, string[] NewAnimalInfo)
        {
            //Using the encapsulation of the private varaibles to organize the fields to store in the file.
            _Name = NewAnimalInfo[0];
            _Breed = NewAnimalInfo[1];
            _Age = NewAnimalInfo[2];
            _Appearance = NewAnimalInfo[3];
            _EnteredShelterDate = NewAnimalInfo[4];
            _AdoptionDate = NewAnimalInfo[5];
            _Gender = NewAnimalInfo[6];
            _ExtraInformation = NewAnimalInfo[7];


            string AnimalInfoFormated = Name + " " + Breed + " " + Age + " " + Appearance + " " + EnteredShelterDate + " " + AdoptionDate + " " + Gender + " ~" + ExtraInformation;
            File.AppendAllText(AnimalFilePath, Environment.NewLine + AnimalInfoFormated);
        }

        public void SaveFirstAnimalToFile(string AnimalFilePath, string[] NewAnimalInfo)
        {
            //Using the encapsulation of the private varaibles to organize the fields to store in the file.
            _Name = NewAnimalInfo[0];
            _Breed = NewAnimalInfo[1];
            _Age = NewAnimalInfo[2];
            _Appearance = NewAnimalInfo[3];
            _EnteredShelterDate = NewAnimalInfo[4];
            _AdoptionDate = NewAnimalInfo[5];
            _Gender = NewAnimalInfo[6];
            _ExtraInformation = NewAnimalInfo[7];


            string AnimalInfoFormated = Name + " " + Breed + " " + Age + " " + Appearance + " " + EnteredShelterDate + " " + AdoptionDate + " " + Gender + " ~" + ExtraInformation;
            File.AppendAllText(AnimalFilePath, AnimalInfoFormated);
        }
        #endregion
        //Had to remove the ~Identifier in fron of the Extra Information
        #region DeleteFileSaves
        public void DeletesSaveAnimalToFile(string AnimalFilePath, string[] NewAnimalInfo)
        {
            //Using the encapsulation of the private varaibles to organize the fields to store in the file.
            _Name = NewAnimalInfo[0];
            _Breed = NewAnimalInfo[1];
            _Age = NewAnimalInfo[2];
            _Appearance = NewAnimalInfo[3];
            _EnteredShelterDate = NewAnimalInfo[4];
            _AdoptionDate = NewAnimalInfo[5];
            _Gender = NewAnimalInfo[6];
            _ExtraInformation = NewAnimalInfo[7];


            string AnimalInfoFormated = Name + " " + Breed + " " + Age + " " + Appearance + " " + EnteredShelterDate + " " + AdoptionDate + " " + Gender + " " + ExtraInformation;
            File.AppendAllText(AnimalFilePath, Environment.NewLine + AnimalInfoFormated);
        }
        public void DeletesSaveFirstAnimalToFile(string AnimalFilePath, string[] NewAnimalInfo)
        {
            //Using the encapsulation of the private varaibles to organize the fields to store in the file.
            _Name = NewAnimalInfo[0];
            _Breed = NewAnimalInfo[1];
            _Age = NewAnimalInfo[2];
            _Appearance = NewAnimalInfo[3];
            _EnteredShelterDate = NewAnimalInfo[4];
            _AdoptionDate = NewAnimalInfo[5];
            _Gender = NewAnimalInfo[6];
            _ExtraInformation = NewAnimalInfo[7];


            string AnimalInfoFormated = Name + " " + Breed + " " + Age + " " + Appearance + " " + EnteredShelterDate + " " + AdoptionDate + " " + Gender + " " + ExtraInformation;
            File.AppendAllText(AnimalFilePath, AnimalInfoFormated);
        }
        #endregion

        //Delete Current Animal
        #region Delete
        public void DeleteAnimalInformation(string AnimalFilePath, string[] SelectedAnimalInfo)
        {
            string[] FirstAnimalFileLine=  SelectedAnimalInfo[0].Split(' '); ;
            //Remove file existing content
            File.WriteAllText(AnimalFilePath, "");

            //Save NewFile Contents to the file

            //To Prevent NewLine at beginning of file
            FirstAnimalFileLine[7] = SelectedAnimalInfo[0].Substring(SelectedAnimalInfo[0].IndexOf('~'));
            DeletesSaveFirstAnimalToFile(AnimalFilePath, FirstAnimalFileLine);
            //The rest of the array contents
            for (int i = 1; i < SelectedAnimalInfo.Length; i++)
            {
                string[] NewAnimalFileWords = SelectedAnimalInfo[i].Split(' ');
                NewAnimalFileWords[7] = SelectedAnimalInfo[i].Substring(SelectedAnimalInfo[i].IndexOf('~'));

                DeletesSaveAnimalToFile(AnimalFilePath, NewAnimalFileWords);
            }
        }
        #endregion
        //Polymorphism for Reptiles and Other to check if animal is poisonous
        #region PolyFunction
        public Boolean WarnIfPoisonous(string SpeciesName, string AnimalsName)
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
