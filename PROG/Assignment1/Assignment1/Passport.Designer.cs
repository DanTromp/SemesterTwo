namespace Assignment1
{
    partial class Passport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblRefusal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountryIssue = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(51, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(123, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblRefusal
            // 
            this.lblRefusal.AutoSize = true;
            this.lblRefusal.Location = new System.Drawing.Point(48, 126);
            this.lblRefusal.Name = "lblRefusal";
            this.lblRefusal.Size = new System.Drawing.Size(216, 13);
            this.lblRefusal.TabIndex = 16;
            this.lblRefusal.Text = "Has this document been refused previously?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(28, 75);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(59, 13);
            this.lblNationality.TabIndex = 14;
            this.lblNationality.Text = "Nationality:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(145, 30);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 13;
            // 
            // lblCountryIssue
            // 
            this.lblCountryIssue.AutoSize = true;
            this.lblCountryIssue.Location = new System.Drawing.Point(28, 38);
            this.lblCountryIssue.Name = "lblCountryIssue";
            this.lblCountryIssue.Size = new System.Drawing.Size(82, 13);
            this.lblCountryIssue.TabIndex = 12;
            this.lblCountryIssue.Text = "Issuing Country:";
            // 
            // Passport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblRefusal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountryIssue);
            this.Name = "Passport";
            this.Text = "Passport";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblRefusal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountryIssue;
    }
}