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
    public partial class RaceForm : Form
    {
        public static Character character = new Character();

        private int _STR = character.charSTR;
        private int _DEX = character.charDEX;
        private int _END = character.charEND;
        private int _INT = character.charINT;
        private int _PER = character.charPER;
        private int _CHA = character.charCHA;

        public RaceForm()
        {
            InitializeComponent();
        }

        private void humanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;

            _STR = _STR + 5;
            _DEX = _DEX + 5;
            _END = _END + 5;
            _INT = _INT + 5;
            _PER = _PER + 5;
            _CHA = _CHA + 5;

            RacialBonusTextBox.Text = "All character abilities are increased by 5.";
        }

        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;

            _STR = _STR + 20;
            _PER = _PER + 20;
            _CHA = _CHA - 10;

            RacialBonusTextBox.Text = "Increase Str and Per by 20, decrease Cha by 10";
        }

        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;

            _DEX = _DEX + 15;
            _CHA = _CHA + 15;

            RacialBonusTextBox.Text = "Increase Dex and Cha by 15.";
        }

        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;

            _DEX = _DEX + 20;
            _INT = _INT + 20;
            _STR = _STR - 10;

            RacialBonusTextBox.Text = " Increase Dex and Int by 20, decrease Str by 10.";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            try
            {
                if (humanRadioButton.Checked == true)
                {
                    character.race = "Human";
                }
                else if (dwarfRadioButton.Checked == true)
                {
                    character.race = "Dwarf";
                }
                else if (elfRadioButton.Checked == true)
                {
                    character.race = "Elf";
                }
                else if (halflingRadioButton.Checked == true)
                {
                    character.race = "Halfling";
                }
                else throw new Exception();
            }
            catch(Exception)
            {
                MessageBox.Show("Please select a race", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();

            JobForm jobForm = new JobForm();

            jobForm.Show();
        }
    }
}
