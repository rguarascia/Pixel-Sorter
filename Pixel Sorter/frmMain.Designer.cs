namespace Pixel_Sorter
{
    partial class frmMain
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.radSort = new System.Windows.Forms.RadioButton();
            this.radRandom = new System.Windows.Forms.RadioButton();
            this.radZoom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(161, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(810, 470);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(143, 28);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Image";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 46);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(143, 28);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Pixels";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 438);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(32, 13);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Res: ";
            // 
            // radSort
            // 
            this.radSort.AutoSize = true;
            this.radSort.Checked = true;
            this.radSort.Location = new System.Drawing.Point(15, 133);
            this.radSort.Name = "radSort";
            this.radSort.Size = new System.Drawing.Size(80, 17);
            this.radSort.TabIndex = 5;
            this.radSort.TabStop = true;
            this.radSort.Text = "Normal Sort";
            this.radSort.UseVisualStyleBackColor = true;
            // 
            // radRandom
            // 
            this.radRandom.AutoSize = true;
            this.radRandom.Location = new System.Drawing.Point(15, 156);
            this.radRandom.Name = "radRandom";
            this.radRandom.Size = new System.Drawing.Size(90, 17);
            this.radRandom.TabIndex = 6;
            this.radRandom.TabStop = true;
            this.radRandom.Text = "Pixel Random";
            this.radRandom.UseVisualStyleBackColor = true;
            // 
            // radZoom
            // 
            this.radZoom.Location = new System.Drawing.Point(15, 179);
            this.radZoom.Name = "radZoom";
            this.radZoom.Size = new System.Drawing.Size(140, 30);
            this.radZoom.TabIndex = 7;
            this.radZoom.TabStop = true;
            this.radZoom.Text = "Pixel Zoom (suggested for large images)";
            this.radZoom.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 500);
            this.Controls.Add(this.radZoom);
            this.Controls.Add(this.radRandom);
            this.Controls.Add(this.radSort);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.picDisplay);
            this.Name = "frmMain";
            this.Text = "Pixel Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.RadioButton radSort;
        private System.Windows.Forms.RadioButton radRandom;
        private System.Windows.Forms.RadioButton radZoom;
    }
}

