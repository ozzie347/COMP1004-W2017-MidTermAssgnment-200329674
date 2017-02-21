using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void RollButton_Click(object sender, EventArgs e)
        {
            STRTextBox.Text = (Roll3D10().ToString());
            DEXTextBox.Text = (Roll3D10().ToString());
            ENDTextBox.Text = (Roll3D10().ToString());
            INTTextBox.Text = (Roll3D10().ToString());
            PERTextBox.Text = (Roll3D10().ToString());
            CHATextBox.Text = (Roll3D10().ToString());
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();

            character.charSTR = Convert.ToInt32(STRTextBox.Text);
            character.charDEX = Convert.ToInt32(DEXTextBox.Text);
            character.charEND = Convert.ToInt32(ENDTextBox.Text);
            character.charINT = Convert.ToInt32(INTTextBox.Text);
            character.charPER = Convert.ToInt32(PERTextBox.Text);
            character.charCHA = Convert.ToInt32(CHATextBox.Text);

            Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.Show();
        }
    }
}
