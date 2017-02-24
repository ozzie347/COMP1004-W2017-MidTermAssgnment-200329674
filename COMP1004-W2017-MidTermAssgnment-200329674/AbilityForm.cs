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
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        //Roll button click event handler
        private void RollButton_Click(object sender, EventArgs e)
        {
            STRTextBox.Text = (Roll3D10().ToString());
            DEXTextBox.Text = (Roll3D10().ToString());
            ENDTextBox.Text = (Roll3D10().ToString());
            INTTextBox.Text = (Roll3D10().ToString());
            PERTextBox.Text = (Roll3D10().ToString());
            CHATextBox.Text = (Roll3D10().ToString());
        }

        /// <summary>
        /// Saves the roll values to the character object or provides an error if values are blank.
        /// Hides the AbilityForm and starts the RaceForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(STRTextBox.Text != null)
                {
                    Program.character.charSTR = Convert.ToInt32(STRTextBox.Text);
                }
                if(DEXTextBox.Text != null)
                {
                    Program.character.charDEX = Convert.ToInt32(DEXTextBox.Text);  
                }
                if(INTTextBox.Text != null)
                {
                    Program.character.charEND = Convert.ToInt32(ENDTextBox.Text);
                }
                if(ENDTextBox.Text != null)
                {
                    Program.character.charINT = Convert.ToInt32(INTTextBox.Text);
                }                
                if(PERTextBox.Text != null)
                {
                    Program.character.charPER = Convert.ToInt32(PERTextBox.Text);
                }
                if(CHATextBox.Text != null)
                {
                    Program.character.charCHA = Convert.ToInt32(CHATextBox.Text);
                }
                else throw new Exception();
            }
            catch(Exception)
            {
                MessageBox.Show("Please roll or enter abilities", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.Show();
        }
    }
}
