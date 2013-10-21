namespace Assignment3
{
    partial class ViewLoaderScreen
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
            this.gridLoader = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateGunType = new System.Windows.Forms.TextBox();
            this.txtUpdateGunAmmo = new System.Windows.Forms.TextBox();
            this.txtUpdateGunYear = new System.Windows.Forms.TextBox();
            this.masktxtUpdateGunWeight = new System.Windows.Forms.MaskedTextBox();
            this.masktxtUpdateGunColour = new System.Windows.Forms.MaskedTextBox();
            this.lblGunColour = new System.Windows.Forms.Label();
            this.lblGunWeight = new System.Windows.Forms.Label();
            this.lblGunYear = new System.Windows.Forms.Label();
            this.lblGunAmmo = new System.Windows.Forms.Label();
            this.lblGunType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLoader
            // 
            this.gridLoader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoader.Location = new System.Drawing.Point(1, 0);
            this.gridLoader.Name = "gridLoader";
            this.gridLoader.Size = new System.Drawing.Size(733, 238);
            this.gridLoader.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(316, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateGunType
            // 
            this.txtUpdateGunType.Location = new System.Drawing.Point(107, 254);
            this.txtUpdateGunType.Name = "txtUpdateGunType";
            this.txtUpdateGunType.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateGunType.TabIndex = 31;
            // 
            // txtUpdateGunAmmo
            // 
            this.txtUpdateGunAmmo.Location = new System.Drawing.Point(331, 254);
            this.txtUpdateGunAmmo.Name = "txtUpdateGunAmmo";
            this.txtUpdateGunAmmo.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateGunAmmo.TabIndex = 30;
            // 
            // txtUpdateGunYear
            // 
            this.txtUpdateGunYear.Location = new System.Drawing.Point(576, 254);
            this.txtUpdateGunYear.Name = "txtUpdateGunYear";
            this.txtUpdateGunYear.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateGunYear.TabIndex = 29;
            // 
            // masktxtUpdateGunWeight
            // 
            this.masktxtUpdateGunWeight.Location = new System.Drawing.Point(197, 298);
            this.masktxtUpdateGunWeight.Mask = "00 kgs";
            this.masktxtUpdateGunWeight.Name = "masktxtUpdateGunWeight";
            this.masktxtUpdateGunWeight.Size = new System.Drawing.Size(100, 20);
            this.masktxtUpdateGunWeight.TabIndex = 28;
            this.masktxtUpdateGunWeight.ValidatingType = typeof(int);
            // 
            // masktxtUpdateGunColour
            // 
            this.masktxtUpdateGunColour.Location = new System.Drawing.Point(483, 298);
            this.masktxtUpdateGunColour.Mask = "LLL???????";
            this.masktxtUpdateGunColour.Name = "masktxtUpdateGunColour";
            this.masktxtUpdateGunColour.Size = new System.Drawing.Size(100, 20);
            this.masktxtUpdateGunColour.TabIndex = 27;
            // 
            // lblGunColour
            // 
            this.lblGunColour.AutoSize = true;
            this.lblGunColour.Location = new System.Drawing.Point(387, 306);
            this.lblGunColour.Name = "lblGunColour";
            this.lblGunColour.Size = new System.Drawing.Size(63, 13);
            this.lblGunColour.TabIndex = 26;
            this.lblGunColour.Text = "Gun Colour:";
            // 
            // lblGunWeight
            // 
            this.lblGunWeight.AutoSize = true;
            this.lblGunWeight.Location = new System.Drawing.Point(101, 306);
            this.lblGunWeight.Name = "lblGunWeight";
            this.lblGunWeight.Size = new System.Drawing.Size(67, 13);
            this.lblGunWeight.TabIndex = 25;
            this.lblGunWeight.Text = "Gun Weight:";
            // 
            // lblGunYear
            // 
            this.lblGunYear.AutoSize = true;
            this.lblGunYear.Location = new System.Drawing.Point(480, 262);
            this.lblGunYear.Name = "lblGunYear";
            this.lblGunYear.Size = new System.Drawing.Size(55, 13);
            this.lblGunYear.TabIndex = 24;
            this.lblGunYear.Text = "Gun Year:";
            // 
            // lblGunAmmo
            // 
            this.lblGunAmmo.AutoSize = true;
            this.lblGunAmmo.Location = new System.Drawing.Point(235, 262);
            this.lblGunAmmo.Name = "lblGunAmmo";
            this.lblGunAmmo.Size = new System.Drawing.Size(62, 13);
            this.lblGunAmmo.TabIndex = 23;
            this.lblGunAmmo.Text = "Gun Ammo:";
            // 
            // lblGunType
            // 
            this.lblGunType.AutoSize = true;
            this.lblGunType.Location = new System.Drawing.Point(11, 261);
            this.lblGunType.Name = "lblGunType";
            this.lblGunType.Size = new System.Drawing.Size(57, 13);
            this.lblGunType.TabIndex = 22;
            this.lblGunType.Text = "Gun Type:";
            // 
            // ViewLoaderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 380);
            this.Controls.Add(this.txtUpdateGunType);
            this.Controls.Add(this.txtUpdateGunAmmo);
            this.Controls.Add(this.txtUpdateGunYear);
            this.Controls.Add(this.masktxtUpdateGunWeight);
            this.Controls.Add(this.masktxtUpdateGunColour);
            this.Controls.Add(this.lblGunColour);
            this.Controls.Add(this.lblGunWeight);
            this.Controls.Add(this.lblGunYear);
            this.Controls.Add(this.lblGunAmmo);
            this.Controls.Add(this.lblGunType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gridLoader);
            this.Name = "ViewLoaderScreen";
            this.Text = "ViewLoaderScreen";
            this.Load += new System.EventHandler(this.ViewLoaderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLoader;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateGunType;
        private System.Windows.Forms.TextBox txtUpdateGunAmmo;
        private System.Windows.Forms.TextBox txtUpdateGunYear;
        private System.Windows.Forms.MaskedTextBox masktxtUpdateGunWeight;
        private System.Windows.Forms.MaskedTextBox masktxtUpdateGunColour;
        private System.Windows.Forms.Label lblGunColour;
        private System.Windows.Forms.Label lblGunWeight;
        private System.Windows.Forms.Label lblGunYear;
        private System.Windows.Forms.Label lblGunAmmo;
        private System.Windows.Forms.Label lblGunType;
    }
}