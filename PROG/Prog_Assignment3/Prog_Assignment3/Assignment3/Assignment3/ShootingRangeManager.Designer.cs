namespace Assignment3
{
    partial class ShootingRangeManager
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
            this.btnFind = new System.Windows.Forms.Button();
            this.masktxtSurname = new System.Windows.Forms.MaskedTextBox();
            this.masktxtFirstName = new System.Windows.Forms.MaskedTextBox();
            this.lblFindSurname = new System.Windows.Forms.Label();
            this.lblFindName = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnViewDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(19, 109);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 32;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // masktxtSurname
            // 
            this.masktxtSurname.Location = new System.Drawing.Point(81, 57);
            this.masktxtSurname.Mask = "LLLL???????";
            this.masktxtSurname.Name = "masktxtSurname";
            this.masktxtSurname.Size = new System.Drawing.Size(100, 20);
            this.masktxtSurname.TabIndex = 31;
            // 
            // masktxtFirstName
            // 
            this.masktxtFirstName.Location = new System.Drawing.Point(81, 22);
            this.masktxtFirstName.Mask = "LLLL???????";
            this.masktxtFirstName.Name = "masktxtFirstName";
            this.masktxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.masktxtFirstName.TabIndex = 30;
            // 
            // lblFindSurname
            // 
            this.lblFindSurname.AutoSize = true;
            this.lblFindSurname.Location = new System.Drawing.Point(16, 64);
            this.lblFindSurname.Name = "lblFindSurname";
            this.lblFindSurname.Size = new System.Drawing.Size(52, 13);
            this.lblFindSurname.TabIndex = 29;
            this.lblFindSurname.Text = "Surname:";
            // 
            // lblFindName
            // 
            this.lblFindName.AutoSize = true;
            this.lblFindName.Location = new System.Drawing.Point(16, 29);
            this.lblFindName.Name = "lblFindName";
            this.lblFindName.Size = new System.Drawing.Size(57, 13);
            this.lblFindName.TabIndex = 28;
            this.lblFindName.Text = "FirstName:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(123, 99);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 33;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Visible = false;
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(100, 109);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(98, 23);
            this.btnViewDatabase.TabIndex = 34;
            this.btnViewDatabase.Text = "View Database";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
            // 
            // ShootingRangeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 144);
            this.Controls.Add(this.btnViewDatabase);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.masktxtSurname);
            this.Controls.Add(this.masktxtFirstName);
            this.Controls.Add(this.lblFindSurname);
            this.Controls.Add(this.lblFindName);
            this.Name = "ShootingRangeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooting Range Manager";
            this.Load += new System.EventHandler(this.Adding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MaskedTextBox masktxtSurname;
        private System.Windows.Forms.MaskedTextBox masktxtFirstName;
        private System.Windows.Forms.Label lblFindSurname;
        private System.Windows.Forms.Label lblFindName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnViewDatabase;



    }
}

