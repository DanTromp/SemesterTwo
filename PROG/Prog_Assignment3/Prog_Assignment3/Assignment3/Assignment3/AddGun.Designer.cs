namespace Assignment3
{
    partial class AddGun
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
            this.txtGunType = new System.Windows.Forms.TextBox();
            this.txtGunAmmo = new System.Windows.Forms.TextBox();
            this.txtGunYear = new System.Windows.Forms.TextBox();
            this.masktxtGunWeight = new System.Windows.Forms.MaskedTextBox();
            this.masktxtGunColour = new System.Windows.Forms.MaskedTextBox();
            this.btnAddGun = new System.Windows.Forms.Button();
            this.lblGunColour = new System.Windows.Forms.Label();
            this.lblGunWeight = new System.Windows.Forms.Label();
            this.lblGunYear = new System.Windows.Forms.Label();
            this.lblGunAmmo = new System.Windows.Forms.Label();
            this.lblGunType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGunType
            // 
            this.txtGunType.Location = new System.Drawing.Point(121, 25);
            this.txtGunType.Name = "txtGunType";
            this.txtGunType.Size = new System.Drawing.Size(100, 20);
            this.txtGunType.TabIndex = 21;
            // 
            // txtGunAmmo
            // 
            this.txtGunAmmo.Location = new System.Drawing.Point(121, 61);
            this.txtGunAmmo.Name = "txtGunAmmo";
            this.txtGunAmmo.Size = new System.Drawing.Size(100, 20);
            this.txtGunAmmo.TabIndex = 20;
            // 
            // txtGunYear
            // 
            this.txtGunYear.Location = new System.Drawing.Point(121, 98);
            this.txtGunYear.Name = "txtGunYear";
            this.txtGunYear.Size = new System.Drawing.Size(100, 20);
            this.txtGunYear.TabIndex = 19;
            // 
            // masktxtGunWeight
            // 
            this.masktxtGunWeight.Location = new System.Drawing.Point(121, 133);
            this.masktxtGunWeight.Mask = "00 kgs";
            this.masktxtGunWeight.Name = "masktxtGunWeight";
            this.masktxtGunWeight.Size = new System.Drawing.Size(100, 20);
            this.masktxtGunWeight.TabIndex = 18;
            this.masktxtGunWeight.ValidatingType = typeof(int);
            // 
            // masktxtGunColour
            // 
            this.masktxtGunColour.Location = new System.Drawing.Point(121, 167);
            this.masktxtGunColour.Mask = "LLL???????";
            this.masktxtGunColour.Name = "masktxtGunColour";
            this.masktxtGunColour.Size = new System.Drawing.Size(100, 20);
            this.masktxtGunColour.TabIndex = 17;
            // 
            // btnAddGun
            // 
            this.btnAddGun.Location = new System.Drawing.Point(146, 224);
            this.btnAddGun.Name = "btnAddGun";
            this.btnAddGun.Size = new System.Drawing.Size(75, 23);
            this.btnAddGun.TabIndex = 16;
            this.btnAddGun.Text = "Add";
            this.btnAddGun.UseVisualStyleBackColor = true;
            this.btnAddGun.Click += new System.EventHandler(this.btnAddGun_Click);
            // 
            // lblGunColour
            // 
            this.lblGunColour.AutoSize = true;
            this.lblGunColour.Location = new System.Drawing.Point(25, 175);
            this.lblGunColour.Name = "lblGunColour";
            this.lblGunColour.Size = new System.Drawing.Size(63, 13);
            this.lblGunColour.TabIndex = 15;
            this.lblGunColour.Text = "Gun Colour:";
            // 
            // lblGunWeight
            // 
            this.lblGunWeight.AutoSize = true;
            this.lblGunWeight.Location = new System.Drawing.Point(25, 141);
            this.lblGunWeight.Name = "lblGunWeight";
            this.lblGunWeight.Size = new System.Drawing.Size(67, 13);
            this.lblGunWeight.TabIndex = 14;
            this.lblGunWeight.Text = "Gun Weight:";
            // 
            // lblGunYear
            // 
            this.lblGunYear.AutoSize = true;
            this.lblGunYear.Location = new System.Drawing.Point(25, 106);
            this.lblGunYear.Name = "lblGunYear";
            this.lblGunYear.Size = new System.Drawing.Size(55, 13);
            this.lblGunYear.TabIndex = 13;
            this.lblGunYear.Text = "Gun Year:";
            // 
            // lblGunAmmo
            // 
            this.lblGunAmmo.AutoSize = true;
            this.lblGunAmmo.Location = new System.Drawing.Point(25, 69);
            this.lblGunAmmo.Name = "lblGunAmmo";
            this.lblGunAmmo.Size = new System.Drawing.Size(62, 13);
            this.lblGunAmmo.TabIndex = 12;
            this.lblGunAmmo.Text = "Gun Ammo:";
            // 
            // lblGunType
            // 
            this.lblGunType.AutoSize = true;
            this.lblGunType.Location = new System.Drawing.Point(25, 32);
            this.lblGunType.Name = "lblGunType";
            this.lblGunType.Size = new System.Drawing.Size(57, 13);
            this.lblGunType.TabIndex = 11;
            this.lblGunType.Text = "Gun Type:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(42, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddGun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 273);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtGunType);
            this.Controls.Add(this.txtGunAmmo);
            this.Controls.Add(this.txtGunYear);
            this.Controls.Add(this.masktxtGunWeight);
            this.Controls.Add(this.masktxtGunColour);
            this.Controls.Add(this.btnAddGun);
            this.Controls.Add(this.lblGunColour);
            this.Controls.Add(this.lblGunWeight);
            this.Controls.Add(this.lblGunYear);
            this.Controls.Add(this.lblGunAmmo);
            this.Controls.Add(this.lblGunType);
            this.Name = "AddGun";
            this.Text = "AddGun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGunType;
        private System.Windows.Forms.TextBox txtGunAmmo;
        private System.Windows.Forms.TextBox txtGunYear;
        private System.Windows.Forms.MaskedTextBox masktxtGunWeight;
        private System.Windows.Forms.MaskedTextBox masktxtGunColour;
        private System.Windows.Forms.Button btnAddGun;
        private System.Windows.Forms.Label lblGunColour;
        private System.Windows.Forms.Label lblGunWeight;
        private System.Windows.Forms.Label lblGunYear;
        private System.Windows.Forms.Label lblGunAmmo;
        private System.Windows.Forms.Label lblGunType;
        private System.Windows.Forms.Button btnClear;
    }
}