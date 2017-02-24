using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200329674
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About");
            this.nameLabel.Text = nameLabel.Text;
            this.studentIDLabel.Text = studentIDLabel.Text;
            this.descriptionTextBox.Text = descriptionTextBox.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
