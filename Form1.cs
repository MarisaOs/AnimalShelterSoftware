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
        //File lines
        string[] DogFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt");
        string[] CatFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Cats.txt");
        string[] OtherAnimalsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Other.txt");
        string[] ReptilesFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Reptiles.txt");
        string[] RodentsFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Rodents.txt");

        
      
        public Form1()
        {
            InitializeComponent();

            AddButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;


        }


        #region AnimalButton

        private void DogButton_Click(object sender, EventArgs e)
        {
            CurrentAnimal = "Dog";
            CurrentAnimalsList.Items.Clear();
            AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\C#DogArt.jpg");
            AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Parse through to get name then add to Doglist
            for (int i = 0; i < DogFileInformationLine.Length; i++)
            {
                string[] DogFileWords = DogFileInformationLine[i].Split(' ');
                CurrentAnimalsList.Items.Add(DogFileWords[0]);
            }


            //For the save button, we can grab the specific array its in and put the array into the save as a parameter.
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            CurrentAnimal = "Cat";
            CurrentAnimalsList.Items.Clear();
            AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\catart.jpg");
            AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Parse through to get name then add to Catlist
            for (int i = 0; i < CatFileInformationLine.Length; i++)
            {
                string[] CatFileWords = CatFileInformationLine[i].Split(' ');
                CurrentAnimalsList.Items.Add(CatFileWords[0]);
            }
        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            CurrentAnimal = "Other";
            CurrentAnimalsList.Items.Clear();
            AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\Others.jpg");
            AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Parse through to get name then add to Otherlist
            for (int i = 0; i < OtherAnimalsFileInformationLine.Length; i++)
            {
                string[] OtherFileWords = OtherAnimalsFileInformationLine[i].Split(' ');
                CurrentAnimalsList.Items.Add(OtherFileWords[0]);
            }
        }

        private void RodentButton_Click(object sender, EventArgs e)
        {
            CurrentAnimal = "Rodent";
            CurrentAnimalsList.Items.Clear();
            AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\Hamster.jpg");
            AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Parse through to get name then add to Rodentlist
            for (int i = 0; i < RodentsFileInformationLine.Length; i++)
            {
                string[] RodentFileWords = RodentsFileInformationLine[i].Split(' ');
                CurrentAnimalsList.Items.Add(RodentFileWords[0]);
            }
        }

        private void ReptileButton_Click(object sender, EventArgs e)
        {
            CurrentAnimal = "Reptile";
            CurrentAnimalsList.Items.Clear();
            AnimalImage.Image = Image.FromFile(@"C:\Users\DSU\source\repos\AnimalShelterSoftware\AnimalImages\Reptiles.jpg");
            AnimalImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Parse through to get name then add to Reptilelist
            for (int i = 0; i < ReptilesFileInformationLine.Length; i++)
            {
                string[] ReptileFileWords = ReptilesFileInformationLine[i].Split(' ');
                CurrentAnimalsList.Items.Add(ReptileFileWords[0]);
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
                Reptile CurrentReptile = new Reptile();
                Boolean IsPoisonous = false;
                Boolean IsVenomous = false;

                for (int i = 0; i < OtherAnimalsFileInformationLine.Length; i++)
                {
                    //Fills out the fields on the UI
                    string[] OtherFileWords = OtherAnimalsFileInformationLine[i].Split(' ');
                    if (OtherFileWords[0] == NameOfSelectedAnimal)
                    {
                        #region ToxicCheck
                        //Venomous check
                        IsVenomous = CurrentReptile.WarnIfVenomous(OtherFileWords[1]);
                        if (IsVenomous)
                        {
                            MessageBox.Show("This animal is Venomous");
                        }
                        //Poisonous check
                        IsPoisonous = CurrentReptile.WarnIfPoisonous(OtherFileWords[1]);
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Format the information into a string and send to the Animal class in the save button
            string[] NewAnimal = { };

            NewAnimal[0] = NameTextBox.Text;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            //Basically, save all the lines except for the one we want to remove, then delete everything in file and only pu thte stuff we want in there
            //string item = usertxt2.Text.Trim();
            //var lines = File.ReadAllLines(usersPath).Where(line => line.Trim() != item).ToArray();
            //File.WriteAllLines(usersPath, lines);

        }

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
