using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelterSoftware
{
    public partial class Form1 : Form
    {
        //Keep track of what list we are in for saving and editing purposes
        public string CurrentAnimal = "";
        //File lines, please be sure you have these files when you try to run the program or it will crash
        #region FileToArray
       
        string[] DogFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt");
        string[] CatFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Cats.txt");
        string[] OtherAnimalsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Other.txt");
        string[] ReptilesFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Reptiles.txt");
        string[] RodentsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Rodents.txt");
        #endregion


        public Form1()
        {
            InitializeComponent();
        }
       
        #region AnimalButton

        private void DogButton_Click(object sender, EventArgs e)
        {
            try 
            {
                CurrentAnimal = "Dog";
                #region Clear
                CurrentAnimalsList.Items.Clear();
                NameTextBox.Text = "";
                BreedTextBox.Text = "";
                AgeTextBox.Text = "";
                AppearanceTextBox.Text = "";
                EnterDateTextBox.Text = "";
                AdoptionDateTextBox.Text = "";
                ExtraInformationTextBox.Text = "";
                GenderTextBox.Text = "";
                #endregion
                AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\C#DogArt.jpg");
                AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

                //Parse through to get name then add to Doglist
                for (int i = 0; i < DogFileInformationLine.Length; i++)
                {
                    string[] DogFileWords = DogFileInformationLine[i].Split(' ');
                    CurrentAnimalsList.Items.Add(DogFileWords[0]);
                }
            }
            catch
            {
                MessageBox.Show("Please be sure you have the necessary Dog file in the right location");
                
            }
  
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentAnimal = "Cat";
                #region Clear
                CurrentAnimalsList.Items.Clear();
                NameTextBox.Text = "";
                BreedTextBox.Text = "";
                AgeTextBox.Text = "";
                AppearanceTextBox.Text = "";
                EnterDateTextBox.Text = "";
                AdoptionDateTextBox.Text = "";
                ExtraInformationTextBox.Text = "";
                GenderTextBox.Text = "";
                #endregion
                AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\catart.jpg");
                AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

                //Parse through to get name then add to Catlist
                for (int i = 0; i < CatFileInformationLine.Length; i++)
                {
                    string[] CatFileWords = CatFileInformationLine[i].Split(' ');
                    CurrentAnimalsList.Items.Add(CatFileWords[0]);
                }
            }
            catch
            {
                MessageBox.Show("Please be sure you have the necessary Cat file in the right location");

            }      
        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentAnimal = "Other";
                #region Clear
                CurrentAnimalsList.Items.Clear();
                NameTextBox.Text = "";
                BreedTextBox.Text = "";
                AgeTextBox.Text = "";
                AppearanceTextBox.Text = "";
                EnterDateTextBox.Text = "";
                AdoptionDateTextBox.Text = "";
                ExtraInformationTextBox.Text = "";
                GenderTextBox.Text = "";
                #endregion
                AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\Others.jpg");
                AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

                //Parse through to get name then add to Otherlist
                for (int i = 0; i < OtherAnimalsFileInformationLine.Length; i++)
                {
                    string[] OtherFileWords = OtherAnimalsFileInformationLine[i].Split(' ');
                    CurrentAnimalsList.Items.Add(OtherFileWords[0]);
                }
            }
            catch
            {
                MessageBox.Show("Please be sure you have the necessary OtherAnimals file in the right location");

            }
           
        }

        private void RodentButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentAnimal = "Rodent";
                #region Clear
                CurrentAnimalsList.Items.Clear();
                NameTextBox.Text = "";
                BreedTextBox.Text = "";
                AgeTextBox.Text = "";
                AppearanceTextBox.Text = "";
                EnterDateTextBox.Text = "";
                AdoptionDateTextBox.Text = "";
                ExtraInformationTextBox.Text = "";
                GenderTextBox.Text = "";
                #endregion
                AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\Hamster.jpg");
                AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

                //Parse through to get name then add to Rodentlist
                for (int i = 0; i < RodentsFileInformationLine.Length; i++)
                {
                    string[] RodentFileWords = RodentsFileInformationLine[i].Split(' ');
                    CurrentAnimalsList.Items.Add(RodentFileWords[0]);
                }
            }
            catch
            {
                MessageBox.Show("Please be sure you have the necessary Rodent file in the right location");

            }
           
        }

        private void ReptileButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentAnimal = "Reptile";
                #region Clear
                CurrentAnimalsList.Items.Clear();
                NameTextBox.Text = "";
                BreedTextBox.Text = "";
                AgeTextBox.Text = "";
                AppearanceTextBox.Text = "";
                EnterDateTextBox.Text = "";
                AdoptionDateTextBox.Text = "";
                ExtraInformationTextBox.Text = "";
                GenderTextBox.Text = "";
                #endregion
                AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\Reptiles.jpg");
                AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

                //Parse through to get name then add to Reptilelist
                for (int i = 0; i < ReptilesFileInformationLine.Length; i++)
                {
                    string[] ReptileFileWords = ReptilesFileInformationLine[i].Split(' ');
                    CurrentAnimalsList.Items.Add(ReptileFileWords[0]);
                }
            }
            catch
            {
                MessageBox.Show("Please be sure you have the necessary Reptile file in the right location");

            }
          
        }
        #endregion

        #region AnimalListBox
        private void CurrentAnimalsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NameOfSelectedAnimal = (CurrentAnimalsList.SelectedItem ?? "(none)").ToString();
            //Name of the animal
            NameTextBox.Text = (CurrentAnimalsList.SelectedItem ?? "(none)").ToString();

            if (CurrentAnimal == "Dog")
            {
                for (int i = 0; i < DogFileInformationLine.Length; i++)
                {
                    //Fills out the fields on the UI
                    string[] DogFileWords = DogFileInformationLine[i].Split(' ');
                    if (DogFileWords[0] == NameOfSelectedAnimal)
                    {
                        BreedTextBox.Text = DogFileWords[1];
                        AgeTextBox.Text = DogFileWords[2];
                        AppearanceTextBox.Text = DogFileWords[3];
                        EnterDateTextBox.Text = DogFileWords[4];
                        AdoptionDateTextBox.Text = DogFileWords[5];
                        GenderTextBox.Text = DogFileWords[6];
                        ExtraInformationTextBox.Text = DogFileInformationLine[i].Substring(DogFileInformationLine[i].IndexOf('~') + 1);

                    }
                }
            }
            if (CurrentAnimal == "Cat")
            {
                for (int i = 0; i < CatFileInformationLine.Length; i++)
                {
                    //Fills out the fields on the UI
                    string[] CatFileWords = CatFileInformationLine[i].Split(' ');
                    if (CatFileWords[0] == NameOfSelectedAnimal)
                    {
                        BreedTextBox.Text = CatFileWords[1];
                        AgeTextBox.Text = CatFileWords[2];
                        AppearanceTextBox.Text = CatFileWords[3];
                        EnterDateTextBox.Text = CatFileWords[4];
                        AdoptionDateTextBox.Text = CatFileWords[5];
                        GenderTextBox.Text = CatFileWords[6];
                        ExtraInformationTextBox.Text = CatFileInformationLine[i].Substring(CatFileInformationLine[i].IndexOf('~') + 1);

                    }
                }
            }
            if (CurrentAnimal == "Other")
            {
                OtherAnimal CurrentOtherAnimal = new OtherAnimal();
                Boolean IsPoisonous = false;

                for (int i = 0; i < OtherAnimalsFileInformationLine.Length; i++)
                {
                    //Fills out the fields on the UI
                    string[] OtherFileWords = OtherAnimalsFileInformationLine[i].Split(' ');
                    if (OtherFileWords[0] == NameOfSelectedAnimal)
                    {
                        #region ToxicCheck
                       
                        //Poisonous check
                        IsPoisonous = CurrentOtherAnimal.WarnIfPoisonous(OtherFileWords[1]);
                        if (IsPoisonous)
                        {
                            MessageBox.Show("This animal is Poisonous");
                        }
                        #endregion
                        BreedTextBox.Text = OtherFileWords[1];
                        AgeTextBox.Text = OtherFileWords[2];
                        AppearanceTextBox.Text = OtherFileWords[3];
                        EnterDateTextBox.Text = OtherFileWords[4];
                        AdoptionDateTextBox.Text = OtherFileWords[5];
                        GenderTextBox.Text = OtherFileWords[6];
                        ExtraInformationTextBox.Text = OtherAnimalsFileInformationLine[i].Substring(OtherAnimalsFileInformationLine[i].IndexOf('~') + 1);

                    }
                }
            }

            if(CurrentAnimal == "Rodent")
            {
                for (int i = 0; i < RodentsFileInformationLine.Length; i++)
                {
                    //Fills out the fields on the UI
                    string[] RodentFileWords = RodentsFileInformationLine[i].Split(' ');
                    if (RodentFileWords[0] == NameOfSelectedAnimal)
                    {
                        BreedTextBox.Text = RodentFileWords[1];
                        AgeTextBox.Text = RodentFileWords[2];
                        AppearanceTextBox.Text = RodentFileWords[3];
                        EnterDateTextBox.Text = RodentFileWords[4];
                        AdoptionDateTextBox.Text = RodentFileWords[5];
                        GenderTextBox.Text = RodentFileWords[6];
                        ExtraInformationTextBox.Text = RodentsFileInformationLine[i].Substring(RodentsFileInformationLine[i].IndexOf('~') + 1);

                    }
                }
            }
            if (CurrentAnimal == "Reptile")
            {
                Reptile CurrentReptile = new Reptile();
                Boolean IsPoisonous = false;
                Boolean IsVenomous = false;
                for (int i = 0; i < ReptilesFileInformationLine.Length; i++)
                {
                    //Fills out the fields on the UI
                    string[] ReptileFileWords = ReptilesFileInformationLine[i].Split(' ');
                    if (ReptileFileWords[0] == NameOfSelectedAnimal)
                    {
                        
                        #region ToxicCheck
                        //Venomous check
                        IsVenomous = CurrentReptile.WarnIfVenomous(ReptileFileWords[1]);
                        if (IsVenomous)
                        {
                            MessageBox.Show("This animal is Venomous");
                        }
                        //Poisonous check
                        IsPoisonous = CurrentReptile.WarnIfPoisonous(ReptileFileWords[1]);
                        if (IsPoisonous)
                        {
                            MessageBox.Show("This animal is Poisonous");
                        }
                        #endregion
                        BreedTextBox.Text = ReptileFileWords[1];
                        AgeTextBox.Text = ReptileFileWords[2];
                        AppearanceTextBox.Text = ReptileFileWords[3];
                        EnterDateTextBox.Text = ReptileFileWords[4];
                        AdoptionDateTextBox.Text = ReptileFileWords[5];
                        GenderTextBox.Text = ReptileFileWords[6];
                        ExtraInformationTextBox.Text = ReptilesFileInformationLine[i].Substring(ReptilesFileInformationLine[i].IndexOf('~') + 1);

                    }
                }
            }
           
        }
        #endregion

        //Add Save Delete
        #region Add
        private void AddButton_Click(object sender, EventArgs e)
        {    
            //Use the current selected animal still.
            NameTextBox.Text = "";
            BreedTextBox.Text = "";
            AgeTextBox.Text = "";
            AppearanceTextBox.Text = "";
            EnterDateTextBox.Text = "";
            AdoptionDateTextBox.Text = "";
            ExtraInformationTextBox.Text = "";
            GenderTextBox.Text = "";
        }
        #endregion

        #region Save
        private void SaveButton_Click(object sender, EventArgs e)
        {

            //Format the information into a string and send to the Animal class in the save button
            string[] NewAnimal = {"","","","","","","","" };

            #region InputValidation
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name before saving");
            }
            if (BreedTextBox.Text == "")
            {
                MessageBox.Show("Please enter breed before saving");
            }
            if (AgeTextBox.Text == "")
            {
                MessageBox.Show("Please enter age before saving");
            }
            if (AppearanceTextBox.Text == "")
            {
                MessageBox.Show("Please enter appearance before saving");
            }
            if (EnterDateTextBox.Text == "")
            {
                MessageBox.Show("Please enter entrance date before saving");
            }
            if (GenderTextBox.Text == "")
            {
                MessageBox.Show("Please enter gender before saving");
            }
            if (ExtraInformationTextBox.Text == "")
            {
                MessageBox.Show("Please enter extra information before saving");
            }
            #endregion
            //If x y and z != ""
            if (NameTextBox.Text != "" && BreedTextBox.Text != "" && AgeTextBox.Text != "" && AppearanceTextBox.Text != "" && EnterDateTextBox.Text != "" && GenderTextBox.Text != "" && ExtraInformationTextBox.Text != "")
            {
                NewAnimal[0] = NameTextBox.Text;
                NewAnimal[1] = BreedTextBox.Text;
                NewAnimal[2] = AgeTextBox.Text;
                NewAnimal[3] = AppearanceTextBox.Text;
                NewAnimal[4] = EnterDateTextBox.Text;
                NewAnimal[5] = AdoptionDateTextBox.Text;
                NewAnimal[6] = GenderTextBox.Text;
                NewAnimal[7] = ExtraInformationTextBox.Text;

                if (CurrentAnimal == "Dog")
                {
                    Dog AddDog = new Dog();

                    AddDog.SaveAnimalToFile(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt", NewAnimal);
                    DogFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt");
                }
                if (CurrentAnimal == "Cat")
                {
                    Cat AddCat = new Cat();
                    AddCat.SaveAnimalToFile(@"C:\Users\DSU\Desktop\ShelterData\Cats.txt", NewAnimal);
                    CatFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Cats.txt");

                }
                if (CurrentAnimal == "Rodent")
                {
                    Rodent AddRodent = new Rodent();
                    AddRodent.SaveAnimalToFile(@"C:\Users\DSU\Desktop\ShelterData\Rodents.txt", NewAnimal);
                    RodentsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Rodents.txt");
                }
                if (CurrentAnimal == "Reptile")
                {
                    Reptile AddReptile = new Reptile();
                    AddReptile.SaveAnimalToFile(@"C:\Users\DSU\Desktop\ShelterData\Reptiles.txt", NewAnimal);
                    ReptilesFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Reptiles.txt");
                }
                if (CurrentAnimal == "Other")
                {
                    OtherAnimal AddOther = new OtherAnimal();
                    AddOther.SaveAnimalToFile(@"C:\Users\DSU\Desktop\ShelterData\Other.txt", NewAnimal);
                    OtherAnimalsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Other.txt");
                }
            }
        }
            

           
        #endregion

        #region Delete
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string NameOfSelectedAnimal = (CurrentAnimalsList.SelectedItem ?? "(none)").ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + NameOfSelectedAnimal + "'s information?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Grabs everything that isnt the deleted line and rewrites it.         
                    string[] NewFileContentsArray;
                    var NewFileContentsList = new List<string>();

                    #region DeleteDog
                    if (CurrentAnimal == "Dog")
                    {
                        for (int i = 0; i < DogFileInformationLine.Length; i++)
                        {
                            //Grab everything that isnt the line we want to remove
                            string[] DogFileWords = DogFileInformationLine[i].Split(' ');
                            if (DogFileWords[0] != NameOfSelectedAnimal)
                            {
                                NewFileContentsList.Add(DogFileInformationLine[i]);

                            }

                        }
                        NewFileContentsArray = NewFileContentsList.ToArray();

                        ////Save NewFile Contents to the file
                        Dog DeleteDog = new Dog();
                        DeleteDog.DeleteAnimalInformation(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt", NewFileContentsArray);

                        //Update List
                        DogFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt");
                    }
                    #endregion

                    #region DeleteCat
                    if (CurrentAnimal == "Cat")
                    {
                        for (int i = 0; i < CatFileInformationLine.Length; i++)
                        {
                            //Grab everything that isnt the line we want to remove
                            string[] CatFileWords = CatFileInformationLine[i].Split(' ');
                            if (CatFileWords[0] != NameOfSelectedAnimal)
                            {
                                NewFileContentsList.Add(CatFileInformationLine[i]);

                            }

                        }
                        NewFileContentsArray = NewFileContentsList.ToArray();

                        ////Save NewFile Contents to the file
                        Cat DeleteCat = new Cat();
                        DeleteCat.DeleteAnimalInformation(@"C:\Users\DSU\Desktop\ShelterData\Cats.txt", NewFileContentsArray);

                        //Update List
                        CatFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Cats.txt");
                    }
                    #endregion

                    #region DeleteRodent
                    if (CurrentAnimal == "Rodent")
                    {
                        for (int i = 0; i < RodentsFileInformationLine.Length; i++)
                        {
                            //Grab everything that isnt the line we want to remove
                            string[] RodentFileWords = RodentsFileInformationLine[i].Split(' ');
                            if (RodentFileWords[0] != NameOfSelectedAnimal)
                            {
                                NewFileContentsList.Add(RodentsFileInformationLine[i]);
                            }
                        }
                        NewFileContentsArray = NewFileContentsList.ToArray();

                        ////Save NewFile Contents to the file
                        Rodent DeleteRodent = new Rodent();
                        DeleteRodent.DeleteAnimalInformation(@"C:\Users\DSU\Desktop\ShelterData\Rodents.txt", NewFileContentsArray);

                        //Update List
                        RodentsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Rodents.txt");
                    }
                    #endregion

                    #region Reptile
                    if (CurrentAnimal == "Reptile")
                    {
                        for (int i = 0; i < ReptilesFileInformationLine.Length; i++)
                        {
                            //Grab everything that isnt the line we want to remove
                            string[] ReptileFileWords = ReptilesFileInformationLine[i].Split(' ');
                            if (ReptileFileWords[0] != NameOfSelectedAnimal)
                            {
                                NewFileContentsList.Add(ReptilesFileInformationLine[i]);
                            }
                        }
                        NewFileContentsArray = NewFileContentsList.ToArray();

                        ////Save NewFile Contents to the file
                        Reptile DeleteReptile = new Reptile();
                        DeleteReptile.DeleteAnimalInformation(@"C:\Users\DSU\Desktop\ShelterData\Reptiles.txt", NewFileContentsArray);

                        //Update List
                        ReptilesFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Reptiles.txt");
                    }
                    #endregion

                    #region Other
                    if (CurrentAnimal == "Other")
                    {
                        for (int i = 0; i < OtherAnimalsFileInformationLine.Length; i++)
                        {
                            //Grab everything that isnt the line we want to remove
                            string[] OtherFileWords = OtherAnimalsFileInformationLine[i].Split(' ');
                            if (OtherFileWords[0] != NameOfSelectedAnimal)
                            {
                                NewFileContentsList.Add(OtherAnimalsFileInformationLine[i]);
                            }
                        }
                        NewFileContentsArray = NewFileContentsList.ToArray();

                        ////Save NewFile Contents to the file
                        OtherAnimal DeleteOther = new OtherAnimal();
                        DeleteOther.DeleteAnimalInformation(@"C:\Users\DSU\Desktop\ShelterData\Other.txt", NewFileContentsArray);

                        //Update List
                        OtherAnimalsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Other.txt");
                    }
                    #endregion
                }
            }
            catch 
            {
                MessageBox.Show("Delete Error, please try again");
            }

        }
        #endregion

        #region Other
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PageTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AnimalImage_Click(object sender, EventArgs e)
        {

        }




        #endregion

       
    }
}
