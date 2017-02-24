using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200329674
{
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        Character character = new Character();

        private void soldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(soldierRadioButton.Checked == true)
            {
                healthTextBox.Text = (30 + character.charEND).ToString();
            }
        }

        private void rogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(rogueRadioButton.Checked == true)
            {
                healthTextBox.Text = (28 + character.charDEX).ToString();
            }
        }

        private void magickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(magickerRadioButton.Checked == true)
            {
                healthTextBox.Text = (15 + character.charINT).ToString();
            }
        }

        private void cultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(cultistRadioButton.Checked == true)
            {
                healthTextBox.Text = (24 + character.charCHA).ToString();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (healthTextBox.Text != "")
                {
                    character.health = Convert.ToInt32(healthTextBox.Text);
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
