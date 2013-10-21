namespace Assignment3
{
    partial class Database
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
            this.gridClient = new System.Windows.Forms.DataGridView();
            this.comboSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClient
            // 
            this.gridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClient.Location = new System.Drawing.Point(2, 31);
            this.gridClient.Name = "gridClient";
            this.gridClient.Size = new System.Drawing.Size(753, 229);
            this.gridClient.TabIndex = 0;
            this.gridClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClient_CellContentClick);
            // 
            // comboSelection
            // 
            this.comboSelection.FormattingEnabled = true;
            this.comboSelection.Items.AddRange(new object[] {
            "Client Table",
            "Gun Table"});
            this.comboSelection.Location = new System.Drawing.Point(154, 4);
            this.comboSelection.Name = "comboSelection";
            this.comboSelection.Size = new System.Drawing.Size(121, 21);
            this.comboSelection.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Which Table To View:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(312, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 256);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSelection);
            this.Controls.Add(this.gridClient);
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCellDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
    }
}