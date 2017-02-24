using System;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200329674
{
    public partial class RaceForm : Form
    {
        private int _STR = Program.character.charSTR;
        private int _DEX = Program.character.charDEX;
        private int _END = Program.character.charEND;
        private int _INT = Program.character.charINT;
        private int _PER = Program.character.charPER;
        private int _CHA = Program.character.charCHA;
        
        public RaceForm()
        {
            InitializeComponent();
        }

        private void humanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;

            Program.character.charSTR = _STR + 5;
            Program.character.charDEX = _DEX + 5;
            Program.character.charEND = _END + 5;
            Program.character.charINT = _INT + 5;
            Program.character.charPER = _PER + 5;
            Program.character.charCHA = _CHA + 5;

            RacialBonusTextBox.Text = "All character abilities are increased by 5.";
        }

        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;

            Program.character.charSTR = _STR + 20;
            Program.character.charPER = _PER + 20;
            Program.character.charCHA = _CHA - 10;

            RacialBonusTextBox.Text = "Increase Str and Per by 20, decrease Cha by 10";
        }

        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;

            Program.character.charDEX = _DEX + 15;
            Program.character.charCHA = _CHA + 15;

            RacialBonusTextBox.Text = "Increase Dex and Cha by 15.";
        }

        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;

            Program.character.charDEX = _DEX + 20;
            Program.character.charINT = _INT + 20;
            Program.character.charSTR = _STR - 10;

            RacialBonusTextBox.Text = " Increase Dex and Int by 20, decrease Str by 10.";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (humanRadioButton.Checked == true)
                {
                    Program.character.race = "Human";
                }
                else if (dwarfRadioButton.Checked == true)
                {
                    Program.character.race = "Dwarf";
                }
                else if (elfRadioButton.Checked == true)
                {
                    Program.character.race = "Elf";
                }
                else if (halflingRadioButton.Checked == true)
                {
                    Program.character.race = "Halfling";
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
