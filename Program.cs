using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterSoftware
{
    internal static class Program
    {
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Open the files and read them into their lists
            List<string> DogList = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt").ToList();
            List<string> CatList = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt").ToList(); 
            List<string> ReptileList = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt").ToList(); 
            List<string> RodentList = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt").ToList(); 
            List<string> OtherList = File.ReadAllLines(@"C:\Users\DSU\Desktop\ShelterData\Dogs.txt").ToList(); 

            //Parse through the data 
            
           


        }
    }
}
