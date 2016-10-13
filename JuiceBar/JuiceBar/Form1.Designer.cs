namespace JuiceBar
{
    partial class JuiceBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuiceBarForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.sixteenOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ladiesCheckBox = new System.Windows.Forms.CheckBox();
            this.energyBoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.vitaminPackCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drinkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noSizeRadioButton);
            this.groupBox1.Controls.Add(this.twentyOunceRadioButton);
            this.groupBox1.Controls.Add(this.sixteenOunceRadioButton);
            this.groupBox1.Controls.Add(this.twelveOunceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(34, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Checked = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(160, 112);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(85, 17);
            this.noSizeRadioButton.TabIndex = 3;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "radioButton1";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            this.noSizeRadioButton.Visible = false;
            // 
            // twentyOunceRadioButton
            // 
            this.twentyOunceRadioButton.AutoSize = true;
            this.twentyOunceRadioButton.Location = new System.Drawing.Point(24, 98);
            this.twentyOunceRadioButton.Name = "twentyOunceRadioButton";
            this.twentyOunceRadioButton.Size = new System.Drawing.Size(102, 17);
            this.twentyOunceRadioButton.TabIndex = 2;
            this.twentyOunceRadioButton.Text = "&20 Ounce - 4.00";
            this.twentyOunceRadioButton.UseVisualStyleBackColor = true;
            this.twentyOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            this.twentyOunceRadioButton.Click += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // sixteenOunceRadioButton
            // 
            this.sixteenOunceRadioButton.AutoSize = true;
            this.sixteenOunceRadioButton.Location = new System.Drawing.Point(24, 66);
            this.sixteenOunceRadioButton.Name = "sixteenOunceRadioButton";
            this.sixteenOunceRadioButton.Size = new System.Drawing.Size(102, 17);
            this.sixteenOunceRadioButton.TabIndex = 1;
            this.sixteenOunceRadioButton.Text = "&16 Ounce - 3.50";
            this.sixteenOunceRadioButton.UseVisualStyleBackColor = true;
            this.sixteenOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            this.sixteenOunceRadioButton.Click += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // twelveOunceRadioButton
            // 
            this.twelveOunceRadioButton.AutoSize = true;
            this.twelveOunceRadioButton.Location = new System.Drawing.Point(24, 31);
            this.twelveOunceRadioButton.Name = "twelveOunceRadioButton";
            this.twelveOunceRadioButton.Size = new System.Drawing.Size(102, 17);
            this.twelveOunceRadioButton.TabIndex = 0;
            this.twelveOunceRadioButton.Text = "12 &Ounce - 3.00";
            this.twelveOunceRadioButton.UseVisualStyleBackColor = true;
            this.twelveOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            this.twelveOunceRadioButton.Click += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ladiesCheckBox);
            this.groupBox2.Controls.Add(this.energyBoosterCheckBox);
            this.groupBox2.Controls.Add(this.vitaminPackCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(34, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras - $0.50 Each";
            // 
            // ladiesCheckBox
            // 
            this.ladiesCheckBox.AutoSize = true;
            this.ladiesCheckBox.Location = new System.Drawing.Point(24, 108);
            this.ladiesCheckBox.Name = "ladiesCheckBox";
            this.ladiesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ladiesCheckBox.TabIndex = 2;
            this.ladiesCheckBox.Text = "For the &Ladies";
            this.ladiesCheckBox.UseVisualStyleBackColor = true;
            this.ladiesCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            this.ladiesCheckBox.Click += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // energyBoosterCheckBox
            // 
            this.energyBoosterCheckBox.AutoSize = true;
            this.energyBoosterCheckBox.Location = new System.Drawing.Point(24, 70);
            this.energyBoosterCheckBox.Name = "energyBoosterCheckBox";
            this.energyBoosterCheckBox.Size = new System.Drawing.Size(98, 17);
            this.energyBoosterCheckBox.TabIndex = 1;
            this.energyBoosterCheckBox.Text = "Energy &Booster";
            this.energyBoosterCheckBox.UseVisualStyleBackColor = true;
            this.energyBoosterCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            this.energyBoosterCheckBox.Click += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // vitaminPackCheckBox
            // 
            this.vitaminPackCheckBox.AutoSize = true;
            this.vitaminPackCheckBox.Location = new System.Drawing.Point(24, 29);
            this.vitaminPackCheckBox.Name = "vitaminPackCheckBox";
            this.vitaminPackCheckBox.Size = new System.Drawing.Size(88, 17);
            this.vitaminPackCheckBox.TabIndex = 0;
            this.vitaminPackCheckBox.Text = "&Vitamin Pack";
            this.vitaminPackCheckBox.UseVisualStyleBackColor = true;
            this.vitaminPackCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            this.vitaminPackCheckBox.Click += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drinkTypeComboBox);
            this.groupBox3.Location = new System.Drawing.Point(324, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select the drink type";
            // 
            // drinkTypeComboBox
            // 
            this.drinkTypeComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drinkTypeComboBox.FormattingEnabled = true;
            this.drinkTypeComboBox.Items.AddRange(new object[] {
            "Fruit juice",
            "Veggie juice",
            "Pomegranate smoothie",
            "Strawberry banana smoothie",
            "Wheatberry smoothie"});
            this.drinkTypeComboBox.Location = new System.Drawing.Point(19, 45);
            this.drinkTypeComboBox.Name = "drinkTypeComboBox";
            this.drinkTypeComboBox.Size = new System.Drawing.Size(141, 21);
            this.drinkTypeComboBox.TabIndex = 0;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(392, 306);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(109, 32);
            this.addToOrderButton.TabIndex = 3;
            this.addToOrderButton.Text = "&Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(392, 382);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(109, 32);
            this.summaryButton.TabIndex = 4;
            this.summaryButton.Text = "Summary &Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Enabled = false;
            this.orderCompleteButton.Location = new System.Drawing.Point(392, 344);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(109, 32);
            this.orderCompleteButton.TabIndex = 5;
            this.orderCompleteButton.Text = "Order &Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(392, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quantityTextBox.Location = new System.Drawing.Point(123, 385);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(111, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(123, 432);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.ReadOnly = true;
            this.itemPriceTextBox.Size = new System.Drawing.Size(111, 20);
            this.itemPriceTextBox.TabIndex = 10;
            this.itemPriceTextBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.orderCompleteToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addToOrderToolStripMenuItem.Text = "&Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderCompleteToolStripMenuItem
            // 
            this.orderCompleteToolStripMenuItem.Name = "orderCompleteToolStripMenuItem";
            this.orderCompleteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.orderCompleteToolStripMenuItem.Text = "&Order Complete ";
            this.orderCompleteToolStripMenuItem.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.colorToolStripMenuItem.Text = "&Color ";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "&Quantity";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(68, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(398, 37);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Look Sharp Fitness Center";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuiceBar.Properties.Resources.la_fitness_juice_bar;
            this.pictureBox1.Location = new System.Drawing.Point(324, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // JuiceBarForm
            // 
            this.AcceptButton = this.addToOrderButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JuiceBarForm";
            this.Text = "Juice Bar Orders";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton twentyOunceRadioButton;
        private System.Windows.Forms.RadioButton sixteenOunceRadioButton;
        private System.Windows.Forms.RadioButton twelveOunceRadioButton;
        private System.Windows.Forms.CheckBox ladiesCheckBox;
        private System.Windows.Forms.CheckBox energyBoosterCheckBox;
        private System.Windows.Forms.CheckBox vitaminPackCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox drinkTypeComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

