namespace ConvertionApp
{
    partial class window
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.convertFile = new System.Windows.Forms.Button();
            this.completelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // chooseBtn
            // 
            this.chooseBtn.Location = new System.Drawing.Point(12, 14);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(87, 33);
            this.chooseBtn.TabIndex = 0;
            this.chooseBtn.Text = "Choose File";
            this.chooseBtn.UseVisualStyleBackColor = true;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(122, 14);
            this.fileName.Multiline = true;
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(254, 31);
            this.fileName.TabIndex = 1;
            this.fileName.TabStop = false;
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(12, 62);
            this.fileLocation.Multiline = true;
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(364, 32);
            this.fileLocation.TabIndex = 2;
            // 
            // convertFile
            // 
            this.convertFile.Location = new System.Drawing.Point(12, 135);
            this.convertFile.Name = "convertFile";
            this.convertFile.Size = new System.Drawing.Size(87, 33);
            this.convertFile.TabIndex = 3;
            this.convertFile.Text = "Convert to xml";
            this.convertFile.UseVisualStyleBackColor = true;
            this.convertFile.Click += new System.EventHandler(this.convertFile_Click);
            // 
            // completelbl
            // 
            this.completelbl.AutoSize = true;
            this.completelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.completelbl.Location = new System.Drawing.Point(-4, 201);
            this.completelbl.Name = "completelbl";
            this.completelbl.Size = new System.Drawing.Size(398, 42);
            this.completelbl.TabIndex = 4;
            this.completelbl.Text = "Conversion Completed";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 319);
            this.Controls.Add(this.completelbl);
            this.Controls.Add(this.convertFile);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.chooseBtn);
            this.Name = "window";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.Button convertFile;
        private System.Windows.Forms.Label completelbl;
    }
}

