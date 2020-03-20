namespace TuBesSTIMA2
{
    partial class Virus_Prévisions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Virus_Prévisions));
            this.LBLInMapFile = new System.Windows.Forms.Label();
            this.LBLInPopulationFile = new System.Windows.Forms.Label();
            this.LBLSaveDirection = new System.Windows.Forms.Label();
            this.LBLInDay = new System.Windows.Forms.Label();
            this.LocMapFile = new System.Windows.Forms.Label();
            this.LocPplFile = new System.Windows.Forms.Label();
            this.LocFolderToSave = new System.Windows.Forms.Label();
            this.buttonMapFile = new System.Windows.Forms.Button();
            this.buttonPopulationFile = new System.Windows.Forms.Button();
            this.buttonSaveFolder = new System.Windows.Forms.Button();
            this.ButtonMakeMap = new System.Windows.Forms.Button();
            this.ButtonClearData = new System.Windows.Forms.Button();
            this.UpDownDayInf = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDayInf)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLInMapFile
            // 
            this.LBLInMapFile.AutoSize = true;
            this.LBLInMapFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLInMapFile.Location = new System.Drawing.Point(12, 15);
            this.LBLInMapFile.Name = "LBLInMapFile";
            this.LBLInMapFile.Size = new System.Drawing.Size(96, 17);
            this.LBLInMapFile.TabIndex = 1;
            this.LBLInMapFile.Text = "Input Map File";
            // 
            // LBLInPopulationFile
            // 
            this.LBLInPopulationFile.AutoSize = true;
            this.LBLInPopulationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLInPopulationFile.Location = new System.Drawing.Point(11, 60);
            this.LBLInPopulationFile.Name = "LBLInPopulationFile";
            this.LBLInPopulationFile.Size = new System.Drawing.Size(136, 17);
            this.LBLInPopulationFile.TabIndex = 2;
            this.LBLInPopulationFile.Text = "Input Population File";
            // 
            // LBLSaveDirection
            // 
            this.LBLSaveDirection.AutoSize = true;
            this.LBLSaveDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLSaveDirection.Location = new System.Drawing.Point(11, 105);
            this.LBLSaveDirection.Name = "LBLSaveDirection";
            this.LBLSaveDirection.Size = new System.Drawing.Size(160, 17);
            this.LBLSaveDirection.TabIndex = 10;
            this.LBLSaveDirection.Text = "Save Simulation Data At";
            // 
            // LBLInDay
            // 
            this.LBLInDay.AutoSize = true;
            this.LBLInDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLInDay.Location = new System.Drawing.Point(11, 150);
            this.LBLInDay.Name = "LBLInDay";
            this.LBLInDay.Size = new System.Drawing.Size(144, 17);
            this.LBLInDay.TabIndex = 5;
            this.LBLInDay.Text = "Input Day Of Infection";
            // 
            // LocMapFile
            // 
            this.LocMapFile.AutoEllipsis = true;
            this.LocMapFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.LocMapFile.ForeColor = System.Drawing.Color.Red;
            this.LocMapFile.Location = new System.Drawing.Point(14, 36);
            this.LocMapFile.Name = "LocMapFile";
            this.LocMapFile.Size = new System.Drawing.Size(234, 19);
            this.LocMapFile.TabIndex = 7;
            this.LocMapFile.Text = "\r\n";
            this.LocMapFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LocPplFile
            // 
            this.LocPplFile.AutoEllipsis = true;
            this.LocPplFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.LocPplFile.ForeColor = System.Drawing.Color.Red;
            this.LocPplFile.Location = new System.Drawing.Point(13, 81);
            this.LocPplFile.Name = "LocPplFile";
            this.LocPplFile.Size = new System.Drawing.Size(235, 19);
            this.LocPplFile.TabIndex = 8;
            this.LocPplFile.Text = "\r\n";
            this.LocPplFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LocFolderToSave
            // 
            this.LocFolderToSave.AutoEllipsis = true;
            this.LocFolderToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.LocFolderToSave.ForeColor = System.Drawing.Color.Red;
            this.LocFolderToSave.Location = new System.Drawing.Point(18, 126);
            this.LocFolderToSave.Name = "LocFolderToSave";
            this.LocFolderToSave.Size = new System.Drawing.Size(235, 19);
            this.LocFolderToSave.TabIndex = 12;
            this.LocFolderToSave.Text = "\r\n";
            this.LocFolderToSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonMapFile
            // 
            this.buttonMapFile.Location = new System.Drawing.Point(173, 12);
            this.buttonMapFile.Name = "buttonMapFile";
            this.buttonMapFile.Size = new System.Drawing.Size(80, 23);
            this.buttonMapFile.TabIndex = 0;
            this.buttonMapFile.Text = "Select File";
            this.buttonMapFile.UseVisualStyleBackColor = true;
            this.buttonMapFile.Click += new System.EventHandler(this.InputMapFile);
            // 
            // buttonPopulationFile
            // 
            this.buttonPopulationFile.Location = new System.Drawing.Point(173, 57);
            this.buttonPopulationFile.Name = "buttonPopulationFile";
            this.buttonPopulationFile.Size = new System.Drawing.Size(80, 23);
            this.buttonPopulationFile.TabIndex = 3;
            this.buttonPopulationFile.Text = "Select File";
            this.buttonPopulationFile.UseVisualStyleBackColor = true;
            this.buttonPopulationFile.Click += new System.EventHandler(this.InputPopulationFile);
            // 
            // buttonSaveFolder
            // 
            this.buttonSaveFolder.Location = new System.Drawing.Point(173, 102);
            this.buttonSaveFolder.Name = "buttonSaveFolder";
            this.buttonSaveFolder.Size = new System.Drawing.Size(80, 23);
            this.buttonSaveFolder.TabIndex = 11;
            this.buttonSaveFolder.Text = "Select Folder";
            this.buttonSaveFolder.UseVisualStyleBackColor = true;
            this.buttonSaveFolder.Click += new System.EventHandler(this.DirectionFolderSave);
            // 
            // ButtonMakeMap
            // 
            this.ButtonMakeMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.ButtonMakeMap.Location = new System.Drawing.Point(15, 204);
            this.ButtonMakeMap.Name = "ButtonMakeMap";
            this.ButtonMakeMap.Size = new System.Drawing.Size(112, 48);
            this.ButtonMakeMap.TabIndex = 6;
            this.ButtonMakeMap.Text = "Infected\r\nCity Map";
            this.ButtonMakeMap.UseVisualStyleBackColor = true;
            this.ButtonMakeMap.Click += new System.EventHandler(this.MakeMap);
            // 
            // ButtonClearData
            // 
            this.ButtonClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.ButtonClearData.Location = new System.Drawing.Point(140, 204);
            this.ButtonClearData.Name = "ButtonClearData";
            this.ButtonClearData.Size = new System.Drawing.Size(113, 48);
            this.ButtonClearData.TabIndex = 9;
            this.ButtonClearData.Text = "Clear All";
            this.ButtonClearData.UseVisualStyleBackColor = true;
            this.ButtonClearData.Click += new System.EventHandler(this.ClearData);
            // 
            // UpDownDayInf
            // 
            this.UpDownDayInf.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpDownDayInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpDownDayInf.Location = new System.Drawing.Point(173, 148);
            this.UpDownDayInf.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.UpDownDayInf.Name = "UpDownDayInf";
            this.UpDownDayInf.Size = new System.Drawing.Size(80, 23);
            this.UpDownDayInf.TabIndex = 13;
            this.UpDownDayInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownDayInf.ValueChanged += new System.EventHandler(this.InfDayUpDown);
            this.UpDownDayInf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InfDayUpDown);
            // 
            // Virus_Prévisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 264);
            this.Controls.Add(this.UpDownDayInf);
            this.Controls.Add(this.ButtonClearData);
            this.Controls.Add(this.ButtonMakeMap);
            this.Controls.Add(this.buttonSaveFolder);
            this.Controls.Add(this.buttonPopulationFile);
            this.Controls.Add(this.buttonMapFile);
            this.Controls.Add(this.LocFolderToSave);
            this.Controls.Add(this.LocPplFile);
            this.Controls.Add(this.LocMapFile);
            this.Controls.Add(this.LBLInDay);
            this.Controls.Add(this.LBLSaveDirection);
            this.Controls.Add(this.LBLInPopulationFile);
            this.Controls.Add(this.LBLInMapFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Virus_Prévisions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIRUS PRÉVISIONS";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDayInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLInMapFile;
        private System.Windows.Forms.Label LBLInPopulationFile;
        private System.Windows.Forms.Label LBLSaveDirection;
        private System.Windows.Forms.Label LBLInDay;
        private System.Windows.Forms.Label LocMapFile;
        private System.Windows.Forms.Label LocPplFile;
        private System.Windows.Forms.Label LocFolderToSave;
        private System.Windows.Forms.Button buttonMapFile;
        private System.Windows.Forms.Button buttonPopulationFile;
        private System.Windows.Forms.Button buttonSaveFolder;
        private System.Windows.Forms.Button ButtonMakeMap;
        private System.Windows.Forms.Button ButtonClearData;
        private System.Windows.Forms.NumericUpDown UpDownDayInf;
    }
}