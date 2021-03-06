﻿/**
App: COMP1004-Midterm
Author: Nicholas Oshukany
Last Modified: 02/24/2017
Description: This program creates a character sheet for role-playing
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200329674
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        //Fill the text boxes with the values from the character object
        public void Values()
        {
            strTextBox.Text = (Program.character.charSTR).ToString();
            dexTextBox.Text = (Program.character.charDEX).ToString();
            endTextBox.Text = (Program.character.charEND).ToString();
            intTextBox.Text = (Program.character.charINT).ToString();
            perTextBox.Text = (Program.character.charPER).ToString();
            chaTextBox.Text = (Program.character.charCHA).ToString();
            jobTextBox.Text = Program.character.job;
            raceTextBox.Text = Program.character.race;
            healthTextBox.Text = (Program.character.health).ToString();
        }

        //Exit the program when the Exit button is clicked or Exit is used from the menu
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Run the values method to fill text boxes and select image to display based on stored race
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Values();

            if(raceTextBox.Text == "Human")
            {
                racePictureBox.Image = Properties.Resources.M_Human1;
            }
            else if(raceTextBox.Text == "Dwarf")
            {
                racePictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else if(raceTextBox.Text == "Elf")
            {
                racePictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if(raceTextBox.Text == "Halfling")
            {
                racePictureBox.Image = Properties.Resources.M_Halfling2;
            }
        }

        //Mock print preview from the menu options
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a mock Print Preview", "Print Preview", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        //Bring up the AboutBox from the menu options
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();

            aboutBox.Show();
        }

        //Bring up the FontDialog from the menu options
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the dialog
            DialogResult result = fontDialog.ShowDialog();

            //See if OK was pressed
            if(result == DialogResult.OK)
            {
                //Get font
                Font font = fontDialog.Font;

                //Set the TextBox/Label properties
                charInfoGroupBox1.Font = font;
                nameLabel.Font = font;
                nameTextBox.Font = font;
                ageLabel.Font = font;
                ageTextBox.Font = font;
                heightLabel.Font = font;
                heightTextBox.Font = font;
                weightLabel.Font = font;
                weightTextBox.Font = font;
                titlesLabel.Font = font;
                titlesTextBox.Font = font;

                jobLabel.Font = font;
                jobTextBox.Font = font;
                raceLabel.Font = font;
                raceTextBox.Font = font;
                healthLabel.Font = font;
                healthTextBox.Font = font;

                abilitiesGroupBox.Font = font;
                strLabel.Font = font;
                strTextBox.Font = font;
                dexLabel.Font = font;
                dexTextBox.Font = font;
                endLabel.Font = font;
                endTextBox.Font = font;
                intLabel.Font = font;
                intTextBox.Font = font;
                perLabel.Font = font;
                perTextBox.Font = font;
                chaLabel.Font = font;
                chaTextBox.Font = font;

                exitButton.Font = font;
            }
        }
    }
}
