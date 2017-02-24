/**
App: COMP1004-Midterm
Author: Nicholas Oshukany
Last Modified: 02/24/2017
Description: This program creates a character sheet for role-playing
*/

using System;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200329674
{
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        //If Soldier radio is selected show calculated health
        private void soldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(soldierRadioButton.Checked == true)
            {
                healthTextBox.Text = (30 + Program.character.charEND).ToString();
            }
        }

        //If Rogue radio is selected show calculated health
        private void rogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(rogueRadioButton.Checked == true)
            {
                healthTextBox.Text = (28 + Program.character.charDEX).ToString();
            }
        }

        //If Magicker radio is selected show calculated health
        private void magickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(magickerRadioButton.Checked == true)
            {
                healthTextBox.Text = (15 + Program.character.charINT).ToString();
            }
        }

        //If Cultist radio is selected show calculated health
        private void cultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(cultistRadioButton.Checked == true)
            {
                healthTextBox.Text = (24 + Program.character.charCHA).ToString();
            }
        }

        /// <summary>
        /// Save the calculated health in the character object or show error if blank.
        /// Hide the form and show the FinalForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (healthTextBox.Text != "")
                {
                    Program.character.health = Convert.ToInt32(healthTextBox.Text);
                }
                if(soldierRadioButton.Checked == true)
                {
                    Program.character.job = "Soldier";
                }
                else if(rogueRadioButton.Checked == true)
                {
                    Program.character.job = "Rogue";
                }
                else if(magickerRadioButton.Checked == true)
                {
                    Program.character.job = "Magicker";
                }
                else if(cultistRadioButton.Checked == true)
                {
                    Program.character.job = "Cultist";
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a job", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.Show();
        }
    }
}
