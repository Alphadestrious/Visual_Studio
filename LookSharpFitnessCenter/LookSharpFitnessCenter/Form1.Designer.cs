namespace LookSharpFitnessCenter
{
    partial class promotionForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.memberIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.departmentGroupBox = new System.Windows.Forms.GroupBox();
            this.clothingRadioButton = new System.Windows.Forms.RadioButton();
            this.equipmentRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceBarRadioButton = new System.Windows.Forms.RadioButton();
            this.membershipRadioButton = new System.Windows.Forms.RadioButton();
            this.personalTrainingRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentPictureBox = new System.Windows.Forms.PictureBox();
            this.imageVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.welcomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.promotionsTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.printForm1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.departmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(589, 509);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape1.BorderWidth = 14;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 585;
            this.lineShape1.Y1 = 46;
            this.lineShape1.Y2 = 46;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(362, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "&Name";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Member &ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(431, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // memberIDMaskedTextBox
            // 
            this.memberIDMaskedTextBox.Location = new System.Drawing.Point(431, 179);
            this.memberIDMaskedTextBox.Mask = "00000";
            this.memberIDMaskedTextBox.Name = "memberIDMaskedTextBox";
            this.memberIDMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberIDMaskedTextBox.TabIndex = 6;
            this.memberIDMaskedTextBox.ValidatingType = typeof(int);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Tag = "Use 5 digit number";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // departmentGroupBox
            // 
            this.departmentGroupBox.Controls.Add(this.personalTrainingRadioButton);
            this.departmentGroupBox.Controls.Add(this.membershipRadioButton);
            this.departmentGroupBox.Controls.Add(this.juiceBarRadioButton);
            this.departmentGroupBox.Controls.Add(this.equipmentRadioButton);
            this.departmentGroupBox.Controls.Add(this.clothingRadioButton);
            this.departmentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentGroupBox.Location = new System.Drawing.Point(27, 109);
            this.departmentGroupBox.Name = "departmentGroupBox";
            this.departmentGroupBox.Size = new System.Drawing.Size(212, 213);
            this.departmentGroupBox.TabIndex = 7;
            this.departmentGroupBox.TabStop = false;
            this.departmentGroupBox.Text = "Department";
            this.departmentGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clothingRadioButton
            // 
            this.clothingRadioButton.AutoSize = true;
            this.clothingRadioButton.Enabled = false;
            this.clothingRadioButton.Location = new System.Drawing.Point(7, 20);
            this.clothingRadioButton.Name = "clothingRadioButton";
            this.clothingRadioButton.Size = new System.Drawing.Size(71, 17);
            this.clothingRadioButton.TabIndex = 0;
            this.clothingRadioButton.TabStop = true;
            this.clothingRadioButton.Text = "&Clothing";
            this.clothingRadioButton.UseVisualStyleBackColor = true;
            this.clothingRadioButton.CheckedChanged += new System.EventHandler(this.clothingRadioButton_CheckedChanged);
            // 
            // equipmentRadioButton
            // 
            this.equipmentRadioButton.AutoSize = true;
            this.equipmentRadioButton.Enabled = false;
            this.equipmentRadioButton.Location = new System.Drawing.Point(7, 60);
            this.equipmentRadioButton.Name = "equipmentRadioButton";
            this.equipmentRadioButton.Size = new System.Drawing.Size(84, 17);
            this.equipmentRadioButton.TabIndex = 1;
            this.equipmentRadioButton.TabStop = true;
            this.equipmentRadioButton.Text = "&Equipment";
            this.equipmentRadioButton.UseVisualStyleBackColor = true;
            this.equipmentRadioButton.CheckedChanged += new System.EventHandler(this.equipmentRadioButton_CheckedChanged);
            // 
            // juiceBarRadioButton
            // 
            this.juiceBarRadioButton.AutoSize = true;
            this.juiceBarRadioButton.Enabled = false;
            this.juiceBarRadioButton.Location = new System.Drawing.Point(7, 100);
            this.juiceBarRadioButton.Name = "juiceBarRadioButton";
            this.juiceBarRadioButton.Size = new System.Drawing.Size(78, 17);
            this.juiceBarRadioButton.TabIndex = 2;
            this.juiceBarRadioButton.TabStop = true;
            this.juiceBarRadioButton.Text = "&Juice Bar";
            this.juiceBarRadioButton.UseVisualStyleBackColor = true;
            this.juiceBarRadioButton.CheckedChanged += new System.EventHandler(this.juiceBarRadioButton_CheckedChanged);
            // 
            // membershipRadioButton
            // 
            this.membershipRadioButton.AutoSize = true;
            this.membershipRadioButton.Enabled = false;
            this.membershipRadioButton.Location = new System.Drawing.Point(7, 140);
            this.membershipRadioButton.Name = "membershipRadioButton";
            this.membershipRadioButton.Size = new System.Drawing.Size(92, 17);
            this.membershipRadioButton.TabIndex = 3;
            this.membershipRadioButton.TabStop = true;
            this.membershipRadioButton.Text = "&Membership";
            this.membershipRadioButton.UseVisualStyleBackColor = true;
            this.membershipRadioButton.CheckedChanged += new System.EventHandler(this.membershipRadioButton_CheckedChanged);
            // 
            // personalTrainingRadioButton
            // 
            this.personalTrainingRadioButton.AutoSize = true;
            this.personalTrainingRadioButton.Enabled = false;
            this.personalTrainingRadioButton.Location = new System.Drawing.Point(7, 180);
            this.personalTrainingRadioButton.Name = "personalTrainingRadioButton";
            this.personalTrainingRadioButton.Size = new System.Drawing.Size(124, 17);
            this.personalTrainingRadioButton.TabIndex = 4;
            this.personalTrainingRadioButton.TabStop = true;
            this.personalTrainingRadioButton.Text = "Personal &Training";
            this.personalTrainingRadioButton.UseVisualStyleBackColor = true;
            this.personalTrainingRadioButton.CheckedChanged += new System.EventHandler(this.personalTrainingRadioButton_CheckedChanged);
            // 
            // departmentPictureBox
            // 
            this.departmentPictureBox.Image = global::LookSharpFitnessCenter.Properties.Resources.JuiceBar;
            this.departmentPictureBox.Location = new System.Drawing.Point(40, 331);
            this.departmentPictureBox.Name = "departmentPictureBox";
            this.departmentPictureBox.Size = new System.Drawing.Size(217, 149);
            this.departmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.departmentPictureBox.TabIndex = 8;
            this.departmentPictureBox.TabStop = false;
            this.departmentPictureBox.Visible = false;
            this.departmentPictureBox.Click += new System.EventHandler(this.departmentPictureBox_Click);
            // 
            // imageVisibleCheckBox
            // 
            this.imageVisibleCheckBox.AutoSize = true;
            this.imageVisibleCheckBox.Location = new System.Drawing.Point(274, 463);
            this.imageVisibleCheckBox.Name = "imageVisibleCheckBox";
            this.imageVisibleCheckBox.Size = new System.Drawing.Size(88, 17);
            this.imageVisibleCheckBox.TabIndex = 9;
            this.imageVisibleCheckBox.Text = "Image &Visible";
            this.imageVisibleCheckBox.UseVisualStyleBackColor = true;
            this.imageVisibleCheckBox.Visible = false;
            this.imageVisibleCheckBox.CheckedChanged += new System.EventHandler(this.imageVisibleCheckBox_CheckedChanged);
            // 
            // welcomeRichTextBox
            // 
            this.welcomeRichTextBox.Location = new System.Drawing.Point(365, 307);
            this.welcomeRichTextBox.Name = "welcomeRichTextBox";
            this.welcomeRichTextBox.Size = new System.Drawing.Size(192, 82);
            this.welcomeRichTextBox.TabIndex = 10;
            this.welcomeRichTextBox.Text = "welcomeRichTextBox";
            this.welcomeRichTextBox.Visible = false;
            // 
            // promotionsTextBox
            // 
            this.promotionsTextBox.Location = new System.Drawing.Point(365, 407);
            this.promotionsTextBox.Name = "promotionsTextBox";
            this.promotionsTextBox.Size = new System.Drawing.Size(192, 20);
            this.promotionsTextBox.TabIndex = 11;
            this.promotionsTextBox.TabStop = false;
            this.promotionsTextBox.Visible = false;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(365, 246);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(73, 23);
            this.signInButton.TabIndex = 12;
            this.signInButton.Text = "&Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // printForm1
            // 
            this.printForm1.Location = new System.Drawing.Point(482, 246);
            this.printForm1.Name = "printForm1";
            this.printForm1.Size = new System.Drawing.Size(75, 23);
            this.printForm1.TabIndex = 13;
            this.printForm1.Text = "&Print";
            this.printForm1.UseVisualStyleBackColor = true;
            this.printForm1.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(482, 457);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // promotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 509);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printForm1);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.promotionsTextBox);
            this.Controls.Add(this.welcomeRichTextBox);
            this.Controls.Add(this.imageVisibleCheckBox);
            this.Controls.Add(this.departmentPictureBox);
            this.Controls.Add(this.departmentGroupBox);
            this.Controls.Add(this.memberIDMaskedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "promotionForm";
            this.departmentGroupBox.ResumeLayout(false);
            this.departmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox memberIDMaskedTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox departmentGroupBox;
        private System.Windows.Forms.RadioButton juiceBarRadioButton;
        private System.Windows.Forms.RadioButton equipmentRadioButton;
        private System.Windows.Forms.RadioButton clothingRadioButton;
        private System.Windows.Forms.RadioButton personalTrainingRadioButton;
        private System.Windows.Forms.RadioButton membershipRadioButton;
        private System.Windows.Forms.PictureBox departmentPictureBox;
        private System.Windows.Forms.CheckBox imageVisibleCheckBox;
        private System.Windows.Forms.RichTextBox welcomeRichTextBox;
        private System.Windows.Forms.TextBox promotionsTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button printForm1;
        private System.Windows.Forms.Button exitButton;
    }
}

