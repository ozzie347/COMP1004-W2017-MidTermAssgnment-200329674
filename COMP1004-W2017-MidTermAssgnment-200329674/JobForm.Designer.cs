namespace COMP1004_W2017_MidTermAssgnment_200329674
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.soldierRadioButton = new System.Windows.Forms.RadioButton();
            this.rogueRadioButton = new System.Windows.Forms.RadioButton();
            this.magickerRadioButton = new System.Windows.Forms.RadioButton();
            this.cultistRadioButton = new System.Windows.Forms.RadioButton();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.jobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Controls.Add(this.cultistRadioButton);
            this.jobGroupBox.Controls.Add(this.magickerRadioButton);
            this.jobGroupBox.Controls.Add(this.rogueRadioButton);
            this.jobGroupBox.Controls.Add(this.soldierRadioButton);
            this.jobGroupBox.Location = new System.Drawing.Point(148, 95);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Size = new System.Drawing.Size(329, 196);
            this.jobGroupBox.TabIndex = 4;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Job:";
            // 
            // soldierRadioButton
            // 
            this.soldierRadioButton.AutoSize = true;
            this.soldierRadioButton.Location = new System.Drawing.Point(7, 22);
            this.soldierRadioButton.Name = "soldierRadioButton";
            this.soldierRadioButton.Size = new System.Drawing.Size(73, 21);
            this.soldierRadioButton.TabIndex = 0;
            this.soldierRadioButton.TabStop = true;
            this.soldierRadioButton.Text = "Soldier";
            this.soldierRadioButton.UseVisualStyleBackColor = true;
            this.soldierRadioButton.CheckedChanged += new System.EventHandler(this.soldierRadioButton_CheckedChanged);
            // 
            // rogueRadioButton
            // 
            this.rogueRadioButton.AutoSize = true;
            this.rogueRadioButton.Location = new System.Drawing.Point(6, 65);
            this.rogueRadioButton.Name = "rogueRadioButton";
            this.rogueRadioButton.Size = new System.Drawing.Size(71, 21);
            this.rogueRadioButton.TabIndex = 1;
            this.rogueRadioButton.TabStop = true;
            this.rogueRadioButton.Text = "Rogue";
            this.rogueRadioButton.UseVisualStyleBackColor = true;
            this.rogueRadioButton.CheckedChanged += new System.EventHandler(this.rogueRadioButton_CheckedChanged);
            // 
            // magickerRadioButton
            // 
            this.magickerRadioButton.AutoSize = true;
            this.magickerRadioButton.Location = new System.Drawing.Point(6, 110);
            this.magickerRadioButton.Name = "magickerRadioButton";
            this.magickerRadioButton.Size = new System.Drawing.Size(86, 21);
            this.magickerRadioButton.TabIndex = 2;
            this.magickerRadioButton.TabStop = true;
            this.magickerRadioButton.Text = "Magicker";
            this.magickerRadioButton.UseVisualStyleBackColor = true;
            this.magickerRadioButton.CheckedChanged += new System.EventHandler(this.magickerRadioButton_CheckedChanged);
            // 
            // cultistRadioButton
            // 
            this.cultistRadioButton.AutoSize = true;
            this.cultistRadioButton.Location = new System.Drawing.Point(6, 156);
            this.cultistRadioButton.Name = "cultistRadioButton";
            this.cultistRadioButton.Size = new System.Drawing.Size(67, 21);
            this.cultistRadioButton.TabIndex = 3;
            this.cultistRadioButton.TabStop = true;
            this.cultistRadioButton.Text = "Cultist";
            this.cultistRadioButton.UseVisualStyleBackColor = true;
            this.cultistRadioButton.CheckedChanged += new System.EventHandler(this.cultistRadioButton_CheckedChanged);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(145, 330);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(53, 17);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health:";
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(204, 330);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.ReadOnly = true;
            this.healthTextBox.Size = new System.Drawing.Size(50, 22);
            this.healthTextBox.TabIndex = 6;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.jobGroupBox.ResumeLayout(false);
            this.jobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox jobGroupBox;
        private System.Windows.Forms.RadioButton cultistRadioButton;
        private System.Windows.Forms.RadioButton magickerRadioButton;
        private System.Windows.Forms.RadioButton rogueRadioButton;
        private System.Windows.Forms.RadioButton soldierRadioButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox healthTextBox;
    }
}