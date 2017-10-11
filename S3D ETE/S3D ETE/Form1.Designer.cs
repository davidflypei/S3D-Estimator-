namespace S3D_ETE
{
    partial class Form1
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
            this.s3dTimeHour = new System.Windows.Forms.NumericUpDown();
            this.s3dTimeMin = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblS3D = new System.Windows.Forms.Label();
            this.lblS3DHour = new System.Windows.Forms.Label();
            this.lblS3DMin = new System.Windows.Forms.Label();
            this.lblFinTimeMin = new System.Windows.Forms.Label();
            this.lblFinTimeHour = new System.Windows.Forms.Label();
            this.lblFinTime = new System.Windows.Forms.Label();
            this.finTimeMin = new System.Windows.Forms.NumericUpDown();
            this.finTimeHour = new System.Windows.Forms.NumericUpDown();
            this.cmdGetPrint = new System.Windows.Forms.Button();
            this.lblEst = new System.Windows.Forms.Label();
            this.cbxPrinter = new System.Windows.Forms.ComboBox();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.txtEstTime = new System.Windows.Forms.TextBox();
            this.cmdGetError = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.s3dTimeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s3dTimeMin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finTimeHour)).BeginInit();
            this.SuspendLayout();
            // 
            // s3dTimeHour
            // 
            this.s3dTimeHour.Location = new System.Drawing.Point(41, 123);
            this.s3dTimeHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.s3dTimeHour.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s3dTimeHour.Name = "s3dTimeHour";
            this.s3dTimeHour.Size = new System.Drawing.Size(57, 22);
            this.s3dTimeHour.TabIndex = 0;
            // 
            // s3dTimeMin
            // 
            this.s3dTimeMin.Location = new System.Drawing.Point(141, 123);
            this.s3dTimeMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.s3dTimeMin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s3dTimeMin.Name = "s3dTimeMin";
            this.s3dTimeMin.Size = new System.Drawing.Size(57, 22);
            this.s3dTimeMin.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(577, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileManage,
            this.menuFileExport,
            this.menuFileImport,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 24);
            this.menuFile.Text = "File";
            // 
            // menuFileManage
            // 
            this.menuFileManage.Name = "menuFileManage";
            this.menuFileManage.Size = new System.Drawing.Size(191, 26);
            this.menuFileManage.Text = "Manage Printers";
            // 
            // menuFileExport
            // 
            this.menuFileExport.Name = "menuFileExport";
            this.menuFileExport.Size = new System.Drawing.Size(191, 26);
            this.menuFileExport.Text = "Export Printer";
            // 
            // menuFileImport
            // 
            this.menuFileImport.Name = "menuFileImport";
            this.menuFileImport.Size = new System.Drawing.Size(191, 26);
            this.menuFileImport.Text = "Import Printer";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(191, 26);
            this.menuFileExit.Text = "Exit";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(53, 24);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(125, 26);
            this.menuHelpAbout.Text = "About";
            // 
            // lblS3D
            // 
            this.lblS3D.AutoSize = true;
            this.lblS3D.Location = new System.Drawing.Point(49, 103);
            this.lblS3D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblS3D.Name = "lblS3D";
            this.lblS3D.Size = new System.Drawing.Size(173, 17);
            this.lblS3D.TabIndex = 5;
            this.lblS3D.Text = "Simplify3D estimated time.";
            // 
            // lblS3DHour
            // 
            this.lblS3DHour.AutoSize = true;
            this.lblS3DHour.Location = new System.Drawing.Point(103, 126);
            this.lblS3DHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblS3DHour.Name = "lblS3DHour";
            this.lblS3DHour.Size = new System.Drawing.Size(30, 17);
            this.lblS3DHour.TabIndex = 6;
            this.lblS3DHour.Text = "Hrs";
            // 
            // lblS3DMin
            // 
            this.lblS3DMin.AutoSize = true;
            this.lblS3DMin.Location = new System.Drawing.Point(207, 126);
            this.lblS3DMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblS3DMin.Name = "lblS3DMin";
            this.lblS3DMin.Size = new System.Drawing.Size(30, 17);
            this.lblS3DMin.TabIndex = 7;
            this.lblS3DMin.Text = "Min";
            // 
            // lblFinTimeMin
            // 
            this.lblFinTimeMin.AutoSize = true;
            this.lblFinTimeMin.Location = new System.Drawing.Point(496, 126);
            this.lblFinTimeMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinTimeMin.Name = "lblFinTimeMin";
            this.lblFinTimeMin.Size = new System.Drawing.Size(30, 17);
            this.lblFinTimeMin.TabIndex = 12;
            this.lblFinTimeMin.Text = "Min";
            // 
            // lblFinTimeHour
            // 
            this.lblFinTimeHour.AutoSize = true;
            this.lblFinTimeHour.Location = new System.Drawing.Point(392, 126);
            this.lblFinTimeHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinTimeHour.Name = "lblFinTimeHour";
            this.lblFinTimeHour.Size = new System.Drawing.Size(30, 17);
            this.lblFinTimeHour.TabIndex = 11;
            this.lblFinTimeHour.Text = "Hrs";
            // 
            // lblFinTime
            // 
            this.lblFinTime.AutoSize = true;
            this.lblFinTime.Location = new System.Drawing.Point(380, 103);
            this.lblFinTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinTime.Name = "lblFinTime";
            this.lblFinTime.Size = new System.Drawing.Size(95, 17);
            this.lblFinTime.TabIndex = 10;
            this.lblFinTime.Text = "Finished time.";
            // 
            // finTimeMin
            // 
            this.finTimeMin.Location = new System.Drawing.Point(431, 123);
            this.finTimeMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finTimeMin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.finTimeMin.Name = "finTimeMin";
            this.finTimeMin.Size = new System.Drawing.Size(57, 22);
            this.finTimeMin.TabIndex = 9;
            // 
            // finTimeHour
            // 
            this.finTimeHour.Location = new System.Drawing.Point(331, 123);
            this.finTimeHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finTimeHour.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.finTimeHour.Name = "finTimeHour";
            this.finTimeHour.Size = new System.Drawing.Size(57, 22);
            this.finTimeHour.TabIndex = 8;
            // 
            // cmdGetPrint
            // 
            this.cmdGetPrint.Location = new System.Drawing.Point(41, 155);
            this.cmdGetPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGetPrint.Name = "cmdGetPrint";
            this.cmdGetPrint.Size = new System.Drawing.Size(137, 25);
            this.cmdGetPrint.TabIndex = 13;
            this.cmdGetPrint.Text = "Get Print Time";
            this.cmdGetPrint.UseVisualStyleBackColor = true;
            this.cmdGetPrint.Click += new System.EventHandler(this.cmdGetPrint_Click);
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(37, 204);
            this.lblEst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(142, 17);
            this.lblEst.TabIndex = 14;
            this.lblEst.Text = "Estimated Print Time:";
            // 
            // cbxPrinter
            // 
            this.cbxPrinter.FormattingEnabled = true;
            this.cbxPrinter.Location = new System.Drawing.Point(263, 33);
            this.cbxPrinter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPrinter.Name = "cbxPrinter";
            this.cbxPrinter.Size = new System.Drawing.Size(159, 24);
            this.cbxPrinter.TabIndex = 15;
            this.cbxPrinter.Text = "Feature Not avaiable";
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Location = new System.Drawing.Point(157, 37);
            this.lblPrinter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(97, 17);
            this.lblPrinter.TabIndex = 16;
            this.lblPrinter.Text = "Select Printer:";
            // 
            // txtEstTime
            // 
            this.txtEstTime.BackColor = System.Drawing.Color.LimeGreen;
            this.txtEstTime.Location = new System.Drawing.Point(41, 224);
            this.txtEstTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstTime.Name = "txtEstTime";
            this.txtEstTime.ReadOnly = true;
            this.txtEstTime.Size = new System.Drawing.Size(136, 22);
            this.txtEstTime.TabIndex = 17;
            // 
            // cmdGetError
            // 
            this.cmdGetError.Location = new System.Drawing.Point(331, 155);
            this.cmdGetError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGetError.Name = "cmdGetError";
            this.cmdGetError.Size = new System.Drawing.Size(137, 25);
            this.cmdGetError.TabIndex = 18;
            this.cmdGetError.Text = "Submit Times";
            this.cmdGetError.UseVisualStyleBackColor = true;
            this.cmdGetError.Click += new System.EventHandler(this.cmdGetError_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(331, 224);
            this.txtError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(136, 22);
            this.txtError.TabIndex = 20;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(327, 204);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(80, 17);
            this.lblError.TabIndex = 19;
            this.lblError.Text = "Total Error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 448);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmdGetError);
            this.Controls.Add(this.txtEstTime);
            this.Controls.Add(this.lblPrinter);
            this.Controls.Add(this.cbxPrinter);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.cmdGetPrint);
            this.Controls.Add(this.lblFinTimeMin);
            this.Controls.Add(this.lblFinTimeHour);
            this.Controls.Add(this.lblFinTime);
            this.Controls.Add(this.finTimeMin);
            this.Controls.Add(this.finTimeHour);
            this.Controls.Add(this.lblS3DMin);
            this.Controls.Add(this.lblS3DHour);
            this.Controls.Add(this.lblS3D);
            this.Controls.Add(this.s3dTimeMin);
            this.Controls.Add(this.s3dTimeHour);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "S3D Time Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s3dTimeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s3dTimeMin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finTimeHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown s3dTimeHour;
        private System.Windows.Forms.NumericUpDown s3dTimeMin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileManage;
        private System.Windows.Forms.ToolStripMenuItem menuFileExport;
        private System.Windows.Forms.ToolStripMenuItem menuFileImport;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.Label lblS3D;
        private System.Windows.Forms.Label lblS3DHour;
        private System.Windows.Forms.Label lblS3DMin;
        private System.Windows.Forms.Label lblFinTimeMin;
        private System.Windows.Forms.Label lblFinTimeHour;
        private System.Windows.Forms.Label lblFinTime;
        private System.Windows.Forms.NumericUpDown finTimeMin;
        private System.Windows.Forms.NumericUpDown finTimeHour;
        private System.Windows.Forms.Button cmdGetPrint;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.ComboBox cbxPrinter;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.TextBox txtEstTime;
        private System.Windows.Forms.Button cmdGetError;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblError;
    }
}

