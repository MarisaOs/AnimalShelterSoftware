namespace AnimalShelterSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PageTitle = new System.Windows.Forms.Label();
            this.CurrentAnimalsList = new System.Windows.Forms.ListBox();
            this.AnimalImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BreedTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AppearanceTextBox = new System.Windows.Forms.TextBox();
            this.EnterDateTextBox = new System.Windows.Forms.TextBox();
            this.AdoptionDateTextBox = new System.Windows.Forms.TextBox();
            this.ExtraInformationTextBox = new System.Windows.Forms.RichTextBox();
            this.DogButton = new System.Windows.Forms.Button();
            this.CatButton = new System.Windows.Forms.Button();
            this.RodentButton = new System.Windows.Forms.Button();
            this.ReptileButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(110, 22);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(817, 60);
            this.PageTitle.TabIndex = 0;
            this.PageTitle.Text = "Paws and Claws Animal Shelter";
            this.PageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentAnimalsList
            // 
            this.CurrentAnimalsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentAnimalsList.FormattingEnabled = true;
            this.CurrentAnimalsList.ItemHeight = 20;
            this.CurrentAnimalsList.Location = new System.Drawing.Point(26, 204);
            this.CurrentAnimalsList.Name = "CurrentAnimalsList";
            this.CurrentAnimalsList.Size = new System.Drawing.Size(233, 382);
            this.CurrentAnimalsList.TabIndex = 1;
            this.CurrentAnimalsList.SelectedIndexChanged += new System.EventHandler(this.CurrentAnimalsList_SelectedIndexChanged);
            // 
            // AnimalImage
            // 
            this.AnimalImage.Location = new System.Drawing.Point(758, 124);
            this.AnimalImage.Name = "AnimalImage";
            this.AnimalImage.Size = new System.Drawing.Size(256, 263);
            this.AnimalImage.TabIndex = 2;
            this.AnimalImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Appearance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Entered Shelter Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adoption Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Extra Information:";
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(489, 122);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 60);
            this.AddButton.TabIndex = 10;
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(566, 123);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 60);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(641, 124);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(60, 62);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(551, 210);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(140, 26);
            this.NameTextBox.TabIndex = 13;
            // 
            // BreedTextBox
            // 
            this.BreedTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreedTextBox.Location = new System.Drawing.Point(551, 248);
            this.BreedTextBox.Name = "BreedTextBox";
            this.BreedTextBox.Size = new System.Drawing.Size(140, 26);
            this.BreedTextBox.TabIndex = 14;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(551, 285);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(140, 26);
            this.AgeTextBox.TabIndex = 15;
            // 
            // AppearanceTextBox
            // 
            this.AppearanceTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppearanceTextBox.Location = new System.Drawing.Point(551, 325);
            this.AppearanceTextBox.Name = "AppearanceTextBox";
            this.AppearanceTextBox.Size = new System.Drawing.Size(140, 26);
            this.AppearanceTextBox.TabIndex = 16;
            // 
            // EnterDateTextBox
            // 
            this.EnterDateTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDateTextBox.Location = new System.Drawing.Point(550, 366);
            this.EnterDateTextBox.Name = "EnterDateTextBox";
            this.EnterDateTextBox.Size = new System.Drawing.Size(140, 26);
            this.EnterDateTextBox.TabIndex = 17;
            // 
            // AdoptionDateTextBox
            // 
            this.AdoptionDateTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdoptionDateTextBox.Location = new System.Drawing.Point(550, 407);
            this.AdoptionDateTextBox.Name = "AdoptionDateTextBox";
            this.AdoptionDateTextBox.Size = new System.Drawing.Size(140, 26);
            this.AdoptionDateTextBox.TabIndex = 18;
            // 
            // ExtraInformationTextBox
            // 
            this.ExtraInformationTextBox.Location = new System.Drawing.Point(285, 490);
            this.ExtraInformationTextBox.Name = "ExtraInformationTextBox";
            this.ExtraInformationTextBox.Size = new System.Drawing.Size(729, 96);
            this.ExtraInformationTextBox.TabIndex = 20;
            this.ExtraInformationTextBox.Text = "";
            // 
            // DogButton
            // 
            this.DogButton.Location = new System.Drawing.Point(26, 134);
            this.DogButton.Name = "DogButton";
            this.DogButton.Size = new System.Drawing.Size(75, 35);
            this.DogButton.TabIndex = 21;
            this.DogButton.Text = "Dog";
            this.DogButton.UseVisualStyleBackColor = true;
            this.DogButton.Click += new System.EventHandler(this.DogButton_Click);
            // 
            // CatButton
            // 
            this.CatButton.Location = new System.Drawing.Point(107, 150);
            this.CatButton.Name = "CatButton";
            this.CatButton.Size = new System.Drawing.Size(75, 35);
            this.CatButton.TabIndex = 22;
            this.CatButton.Text = "Cat";
            this.CatButton.UseVisualStyleBackColor = true;
            // 
            // RodentButton
            // 
            this.RodentButton.Location = new System.Drawing.Point(26, 169);
            this.RodentButton.Name = "RodentButton";
            this.RodentButton.Size = new System.Drawing.Size(75, 35);
            this.RodentButton.TabIndex = 23;
            this.RodentButton.Text = "Rodent";
            this.RodentButton.UseVisualStyleBackColor = true;
            // 
            // ReptileButton
            // 
            this.ReptileButton.Location = new System.Drawing.Point(185, 169);
            this.ReptileButton.Name = "ReptileButton";
            this.ReptileButton.Size = new System.Drawing.Size(75, 35);
            this.ReptileButton.TabIndex = 24;
            this.ReptileButton.Text = "Reptile";
            this.ReptileButton.UseVisualStyleBackColor = true;
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(185, 134);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(75, 35);
            this.OtherButton.TabIndex = 25;
            this.OtherButton.Text = "Other";
            this.OtherButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.ReptileButton);
            this.Controls.Add(this.RodentButton);
            this.Controls.Add(this.CatButton);
            this.Controls.Add(this.DogButton);
            this.Controls.Add(this.ExtraInformationTextBox);
            this.Controls.Add(this.AdoptionDateTextBox);
            this.Controls.Add(this.EnterDateTextBox);
            this.Controls.Add(this.AppearanceTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.BreedTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnimalImage);
            this.Controls.Add(this.CurrentAnimalsList);
            this.Controls.Add(this.PageTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paws&Claws Animal Shelter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.ListBox CurrentAnimalsList;
        private System.Windows.Forms.PictureBox AnimalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox BreedTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox AppearanceTextBox;
        private System.Windows.Forms.TextBox EnterDateTextBox;
        private System.Windows.Forms.TextBox AdoptionDateTextBox;
        private System.Windows.Forms.RichTextBox ExtraInformationTextBox;
        private System.Windows.Forms.Button DogButton;
        private System.Windows.Forms.Button CatButton;
        private System.Windows.Forms.Button RodentButton;
        private System.Windows.Forms.Button ReptileButton;
        private System.Windows.Forms.Button OtherButton;
    }
}

