using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LookSharpFitnessCenter
{
    public partial class promotionForm : Form
    {
        public promotionForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // Display the specials, set the visibility of the controls.
            welcomeRichTextBox.Text = "Welcome Member #"
            + memberIDMaskedTextBox.Text
            + Environment.NewLine + nameTextBox.Text;
            // Set visibility properties.
            label4.Visible = false;
            memberIDMaskedTextBox.Visible = false;
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            welcomeRichTextBox.Visible = true;
            promotionsTextBox.Visible = true;
            imageVisibleCheckBox.Visible = true;
            departmentPictureBox.Visible = true;
            // Enable the radio buttons.
            departmentGroupBox.Enabled = true;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Print the form as a print preview.
            printForm1.PrintAction =
            System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the project.
            this.Close();
        }

        private void clothingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the clothing image and show the special.
            departmentPictureBox.Image =
            LookSharpFitnessCenter.Properties.Resources.GymClothing;
            promotionsTextBox.Text = "30% off clearance items.";
        }

        private void equipmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the equipment image and show the special.
            departmentPictureBox.Image =
            LookSharpFitnessCenter.Properties.Resources.GymEquipment2;
            promotionsTextBox.Text = "25% off all equipment.";
        }

        private void juiceBarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the juice bar image and show the special.
            departmentPictureBox.Image =
            LookSharpFitnessCenter.Properties.Resources.JuiceBar2;
            promotionsTextBox.Text = "Free serving of WheatBerry Shake.";
        }

        private void membershipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the membership image and show the special.
            departmentPictureBox.Image =
            LookSharpFitnessCenter.Properties.Resources.Fitness1;
            promotionsTextBox.Text = "Free Personal Trainer for 1st month.";
        }

        private void personalTrainingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the personal training image and show the special.
            departmentPictureBox.Image =
            LookSharpFitnessCenter.Properties.Resources.PersonalTrainer;
            promotionsTextBox.Text = "3 free sessions with membership renewal.";
        }

        private void imageVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of the department image.
            departmentPictureBox.Visible = imageVisibleCheckBox.Checked;
        }

        private void departmentPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
