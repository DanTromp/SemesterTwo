namespace Assignment3
{
    partial class AddClient
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
            this.masktxtIDNum = new System.Windows.Forms.MaskedTextBox();
            this.masktxtCellNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.masktxtSurname = new System.Windows.Forms.MaskedTextBox();
            this.masktxtName = new System.Windows.Forms.MaskedTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // masktxtIDNum
            // 
            this.masktxtIDNum.Location = new System.Drawing.Point(106, 158);
            this.masktxtIDNum.Mask = "0000000000000";
            this.masktxtIDNum.Name = "masktxtIDNum";
            this.masktxtIDNum.Size = new System.Drawing.Size(100, 20);
            this.masktxtIDNum.TabIndex = 41;
            // 
            // masktxtCellNumber
            // 
            this.masktxtCellNumber.Location = new System.Drawing.Point(106, 190);
            this.masktxtCellNumber.Mask = "(999) 000-0000";
            this.masktxtCellNumber.Name = "masktxtCellNumber";
            this.masktxtCellNumber.Size = new System.Drawing.Size(100, 20);
            this.masktxtCellNumber.TabIndex = 40;
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Location = new System.Drawing.Point(32, 197);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(64, 13);
            this.lblCellNumber.TabIndex = 39;
            this.lblCellNumber.Text = "CellNumber:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(91, 234);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 38;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // masktxtSurname
            // 
            this.masktxtSurname.Location = new System.Drawing.Point(106, 51);
            this.masktxtSurname.Mask = "LLLL???????";
            this.masktxtSurname.Name = "masktxtSurname";
            this.masktxtSurname.Size = new System.Drawing.Size(100, 20);
            this.masktxtSurname.TabIndex = 37;
            // 
            // masktxtName
            // 
            this.masktxtName.Location = new System.Drawing.Point(106, 16);
            this.masktxtName.Mask = "LLLL???????";
            this.masktxtName.Name = "masktxtName";
            this.masktxtName.Size = new System.Drawing.Size(100, 20);
            this.masktxtName.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 166);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 13);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "ID Num:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 89);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 32;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(35, 96);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(32, 59);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 30;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Firstname:";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 273);
            this.Controls.Add(this.masktxtIDNum);
            this.Controls.Add(this.masktxtCellNumber);
            this.Controls.Add(this.lblCellNumber);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.masktxtSurname);
            this.Controls.Add(this.masktxtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masktxtIDNum;
        private System.Windows.Forms.MaskedTextBox masktxtCellNumber;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.MaskedTextBox masktxtSurname;
        private System.Windows.Forms.MaskedTextBox masktxtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
    }
}