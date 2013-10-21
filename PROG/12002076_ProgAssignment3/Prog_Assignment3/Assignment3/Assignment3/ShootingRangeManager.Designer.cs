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
            this.btnAddNewGun = new System.Windows.Forms.Button();
            this.btnViewDatabase = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.btnAddButtons = new System.Windows.Forms.Button();
            this.mnuEdit = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTheAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(14, 117);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 32;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // masktxtSurname
            // 
            this.masktxtSurname.Location = new System.Drawing.Point(85, 62);
            this.masktxtSurname.Mask = "LLLL???????";
            this.masktxtSurname.Name = "masktxtSurname";
            this.masktxtSurname.Size = new System.Drawing.Size(100, 20);
            this.masktxtSurname.TabIndex = 31;
            // 
            // masktxtFirstName
            // 
            this.masktxtFirstName.Location = new System.Drawing.Point(85, 27);
            this.masktxtFirstName.Mask = "LLLL???????";
            this.masktxtFirstName.Name = "masktxtFirstName";
            this.masktxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.masktxtFirstName.TabIndex = 30;
            // 
            // lblFindSurname
            // 
            this.lblFindSurname.AutoSize = true;
            this.lblFindSurname.Location = new System.Drawing.Point(20, 69);
            this.lblFindSurname.Name = "lblFindSurname";
            this.lblFindSurname.Size = new System.Drawing.Size(52, 13);
            this.lblFindSurname.TabIndex = 29;
            this.lblFindSurname.Text = "Surname:";
            // 
            // lblFindName
            // 
            this.lblFindName.AutoSize = true;
            this.lblFindName.Location = new System.Drawing.Point(20, 34);
            this.lblFindName.Name = "lblFindName";
            this.lblFindName.Size = new System.Drawing.Size(57, 13);
            this.lblFindName.TabIndex = 28;
            this.lblFindName.Text = "FirstName:";
            // 
            // btnAddNewGun
            // 
            this.btnAddNewGun.Location = new System.Drawing.Point(6, 88);
            this.btnAddNewGun.Name = "btnAddNewGun";
            this.btnAddNewGun.Size = new System.Drawing.Size(83, 23);
            this.btnAddNewGun.TabIndex = 33;
            this.btnAddNewGun.Text = "Add New Gun";
            this.btnAddNewGun.UseVisualStyleBackColor = true;
            this.btnAddNewGun.Visible = false;
            this.btnAddNewGun.Click += new System.EventHandler(this.btnAddNewGun_Click);
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(104, 117);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(98, 23);
            this.btnViewDatabase.TabIndex = 34;
            this.btnViewDatabase.Text = "View Database";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Location = new System.Drawing.Point(114, 88);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(98, 23);
            this.btnAddNewClient.TabIndex = 35;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Visible = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.AddNewClient_Click);
            // 
            // btnAddButtons
            // 
            this.btnAddButtons.Location = new System.Drawing.Point(64, 88);
            this.btnAddButtons.Name = "btnAddButtons";
            this.btnAddButtons.Size = new System.Drawing.Size(75, 23);
            this.btnAddButtons.TabIndex = 36;
            this.btnAddButtons.Text = "Add";
            this.btnAddButtons.UseVisualStyleBackColor = true;
            this.btnAddButtons.Click += new System.EventHandler(this.btnAddButtons_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuEdit.Location = new System.Drawing.Point(0, 0);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(219, 24);
            this.mnuEdit.TabIndex = 37;
            this.mnuEdit.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGunToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.exitTheAppToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewGunToolStripMenuItem
            // 
            this.addNewGunToolStripMenuItem.Name = "addNewGunToolStripMenuItem";
            this.addNewGunToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewGunToolStripMenuItem.Text = "Add New Gun";
            this.addNewGunToolStripMenuItem.Click += new System.EventHandler(this.addNewGunToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // exitTheAppToolStripMenuItem
            // 
            this.exitTheAppToolStripMenuItem.Name = "exitTheAppToolStripMenuItem";
            this.exitTheAppToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitTheAppToolStripMenuItem.Text = "Exit The App";
            this.exitTheAppToolStripMenuItem.Click += new System.EventHandler(this.exitTheAppToolStripMenuItem_Click);
            // 
            // ShootingRangeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 151);
            this.Controls.Add(this.btnAddButtons);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.btnViewDatabase);
            this.Controls.Add(this.btnAddNewGun);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.masktxtSurname);
            this.Controls.Add(this.masktxtFirstName);
            this.Controls.Add(this.lblFindSurname);
            this.Controls.Add(this.lblFindName);
            this.Controls.Add(this.mnuEdit);
            this.MainMenuStrip = this.mnuEdit;
            this.Name = "ShootingRangeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooting Range Manager";
            this.Load += new System.EventHandler(this.Adding_Load);
            this.mnuEdit.ResumeLayout(false);
            this.mnuEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MaskedTextBox masktxtSurname;
        private System.Windows.Forms.MaskedTextBox masktxtFirstName;
        private System.Windows.Forms.Label lblFindSurname;
        private System.Windows.Forms.Label lblFindName;
        private System.Windows.Forms.Button btnAddNewGun;
        private System.Windows.Forms.Button btnViewDatabase;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnAddButtons;
        private System.Windows.Forms.MenuStrip mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewGunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTheAppToolStripMenuItem;



    }
}

