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
        string[] DogFileInformationLine = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt");
        public string CurrentAnimal = "";
        public Form1()
        {
            InitializeComponent();

            //Initialize the strings
          
        }

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

        private void DogButton_Click(object sender, EventArgs e)
        {
            CurrentAnimal = "Dog";
            CurrentAnimalsList.ClearSelected();        
           
            //Parse through to get name then add to Doglist
            for (int i = 0; i < DogFileInformationLine.Length; i++)
            {
                string[] DogFileWords = DogFileInformationLine[i].Split(' ');
                CurrentAnimalsList.Items.Add(DogFileWords[0]);
            }


         

            //For the save button, we can grab the specific array its in and put the array into the save as a parameter.
        }

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
                        ExtraInformationTextBox.Text = DogFileInformationLine[i].Substring(DogFileInformationLine[i].IndexOf('~') + 1);

                    }
                }
            }
           

           
        }
       
    }
}
