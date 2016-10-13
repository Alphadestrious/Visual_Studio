namespace JuiceBar
{
    partial class SummaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drinksSoldTextBox = new System.Windows.Forms.TextBox();
            this.numberOrdersTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drinks Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Sales";
            // 
            // drinksSoldTextBox
            // 
            this.drinksSoldTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.drinksSoldTextBox.Location = new System.Drawing.Point(226, 75);
            this.drinksSoldTextBox.Name = "drinksSoldTextBox";
            this.drinksSoldTextBox.Size = new System.Drawing.Size(129, 20);
            this.drinksSoldTextBox.TabIndex = 3;
            // 
            // numberOrdersTextBox
            // 
            this.numberOrdersTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numberOrdersTextBox.Location = new System.Drawing.Point(226, 123);
            this.numberOrdersTextBox.Name = "numberOrdersTextBox";
            this.numberOrdersTextBox.Size = new System.Drawing.Size(129, 20);
            this.numberOrdersTextBox.TabIndex = 4;
            // 
            // totalSalesTextBox
            // 
            this.totalSalesTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.totalSalesTextBox.Location = new System.Drawing.Point(226, 171);
            this.totalSalesTextBox.Name = "totalSalesTextBox";
            this.totalSalesTextBox.Size = new System.Drawing.Size(129, 20);
            this.totalSalesTextBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(334, 223);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(84, 34);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Summary Form";
            // 
            // SummaryForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(430, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.totalSalesTextBox);
            this.Controls.Add(this.numberOrdersTextBox);
            this.Controls.Add(this.drinksSoldTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SummaryForm";
            this.Text = "Juice Bar Sales Summary";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drinksSoldTextBox;
        private System.Windows.Forms.TextBox numberOrdersTextBox;
        private System.Windows.Forms.TextBox totalSalesTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label4;
    }
}