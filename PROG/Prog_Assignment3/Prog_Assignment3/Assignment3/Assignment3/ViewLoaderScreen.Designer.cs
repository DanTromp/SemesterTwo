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
            // ViewLoaderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 234);
            this.Controls.Add(this.gridLoader);
            this.Name = "ViewLoaderScreen";
            this.Text = "ViewLoaderScreen";
            this.Load += new System.EventHandler(this.ViewLoaderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLoader;
    }
}