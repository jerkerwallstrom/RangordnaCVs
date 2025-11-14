namespace RangordnaCVs
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
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.btnKeyWord = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblKeywordFile = new System.Windows.Forms.Label();
            this.lblAssignmentDesc = new System.Windows.Forms.Label();
            this.btnAssignmentDesc = new System.Windows.Forms.Button();
            this.lblAssigmentFile = new System.Windows.Forms.Label();
            this.lblSelectedCVfolder = new System.Windows.Forms.Label();
            this.btnCVFolder = new System.Windows.Forms.Button();
            this.lblCandidateFolder = new System.Windows.Forms.Label();
            this.btnStartEvaluation = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.lblPythonFile = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.Location = new System.Drawing.Point(18, 26);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(88, 13);
            this.lblKeyWord.TabIndex = 0;
            this.lblKeyWord.Text = "Välj nyckelordsfil:";
            // 
            // btnKeyWord
            // 
            this.btnKeyWord.Location = new System.Drawing.Point(112, 21);
            this.btnKeyWord.Name = "btnKeyWord";
            this.btnKeyWord.Size = new System.Drawing.Size(75, 23);
            this.btnKeyWord.TabIndex = 1;
            this.btnKeyWord.Text = "Nyckelord";
            this.btnKeyWord.UseVisualStyleBackColor = true;
            this.btnKeyWord.Click += new System.EventHandler(this.btnKeyWord_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblKeywordFile
            // 
            this.lblKeywordFile.AutoSize = true;
            this.lblKeywordFile.Location = new System.Drawing.Point(18, 59);
            this.lblKeywordFile.Name = "lblKeywordFile";
            this.lblKeywordFile.Size = new System.Drawing.Size(198, 13);
            this.lblKeywordFile.TabIndex = 2;
            this.lblKeywordFile.Text = "C:\\Dev\\TestData\\weightedkeywords.txt";
            // 
            // lblAssignmentDesc
            // 
            this.lblAssignmentDesc.AutoSize = true;
            this.lblAssignmentDesc.Location = new System.Drawing.Point(18, 129);
            this.lblAssignmentDesc.Name = "lblAssignmentDesc";
            this.lblAssignmentDesc.Size = new System.Drawing.Size(147, 13);
            this.lblAssignmentDesc.TabIndex = 5;
            this.lblAssignmentDesc.Text = "C:\\Dev\\TestData\\jobdesc.txt";
            // 
            // btnAssignmentDesc
            // 
            this.btnAssignmentDesc.Location = new System.Drawing.Point(152, 91);
            this.btnAssignmentDesc.Name = "btnAssignmentDesc";
            this.btnAssignmentDesc.Size = new System.Drawing.Size(122, 23);
            this.btnAssignmentDesc.TabIndex = 4;
            this.btnAssignmentDesc.Text = "Uppdragsbeskrivning";
            this.btnAssignmentDesc.UseVisualStyleBackColor = true;
            this.btnAssignmentDesc.Click += new System.EventHandler(this.btnAssignmentDesc_Click);
            // 
            // lblAssigmentFile
            // 
            this.lblAssigmentFile.AutoSize = true;
            this.lblAssigmentFile.Location = new System.Drawing.Point(18, 96);
            this.lblAssigmentFile.Name = "lblAssigmentFile";
            this.lblAssigmentFile.Size = new System.Drawing.Size(128, 13);
            this.lblAssigmentFile.TabIndex = 3;
            this.lblAssigmentFile.Text = "Välj uppdragsbeskrivning:";
            // 
            // lblSelectedCVfolder
            // 
            this.lblSelectedCVfolder.AutoSize = true;
            this.lblSelectedCVfolder.Location = new System.Drawing.Point(18, 197);
            this.lblSelectedCVfolder.Name = "lblSelectedCVfolder";
            this.lblSelectedCVfolder.Size = new System.Drawing.Size(110, 13);
            this.lblSelectedCVfolder.TabIndex = 8;
            this.lblSelectedCVfolder.Text = "C:\\Dev\\TestData\\CV";
            // 
            // btnCVFolder
            // 
            this.btnCVFolder.Location = new System.Drawing.Point(152, 159);
            this.btnCVFolder.Name = "btnCVFolder";
            this.btnCVFolder.Size = new System.Drawing.Size(122, 23);
            this.btnCVFolder.TabIndex = 7;
            this.btnCVFolder.Text = "CV katalog";
            this.btnCVFolder.UseVisualStyleBackColor = true;
            this.btnCVFolder.Click += new System.EventHandler(this.btnCVFolder_Click);
            // 
            // lblCandidateFolder
            // 
            this.lblCandidateFolder.AutoSize = true;
            this.lblCandidateFolder.Location = new System.Drawing.Point(18, 164);
            this.lblCandidateFolder.Name = "lblCandidateFolder";
            this.lblCandidateFolder.Size = new System.Drawing.Size(82, 13);
            this.lblCandidateFolder.TabIndex = 6;
            this.lblCandidateFolder.Text = "Välj CV katalog:";
            // 
            // btnStartEvaluation
            // 
            this.btnStartEvaluation.Location = new System.Drawing.Point(21, 240);
            this.btnStartEvaluation.Name = "btnStartEvaluation";
            this.btnStartEvaluation.Size = new System.Drawing.Size(166, 23);
            this.btnStartEvaluation.TabIndex = 9;
            this.btnStartEvaluation.Text = "Starta utvärdering";
            this.btnStartEvaluation.UseVisualStyleBackColor = true;
            this.btnStartEvaluation.Click += new System.EventHandler(this.btnStartEvaluation_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(335, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(430, 416);
            this.textBoxOutput.TabIndex = 10;
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPythonFile
            // 
            this.lblPythonFile.AutoSize = true;
            this.lblPythonFile.Location = new System.Drawing.Point(21, 409);
            this.lblPythonFile.Name = "lblPythonFile";
            this.lblPythonFile.Size = new System.Drawing.Size(53, 13);
            this.lblPythonFile.TabIndex = 11;
            this.lblPythonFile.Text = "Pythonfile";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 283);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(21, 325);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(85, 23);
            this.btnClearOutput.TabIndex = 13;
            this.btnClearOutput.Text = "Rensa resultat";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPythonFile);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.btnStartEvaluation);
            this.Controls.Add(this.lblSelectedCVfolder);
            this.Controls.Add(this.btnCVFolder);
            this.Controls.Add(this.lblCandidateFolder);
            this.Controls.Add(this.lblAssignmentDesc);
            this.Controls.Add(this.btnAssignmentDesc);
            this.Controls.Add(this.lblAssigmentFile);
            this.Controls.Add(this.lblKeywordFile);
            this.Controls.Add(this.btnKeyWord);
            this.Controls.Add(this.lblKeyWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyWord;
        private System.Windows.Forms.Button btnKeyWord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblKeywordFile;
        private System.Windows.Forms.Label lblAssignmentDesc;
        private System.Windows.Forms.Button btnAssignmentDesc;
        private System.Windows.Forms.Label lblAssigmentFile;
        private System.Windows.Forms.Label lblSelectedCVfolder;
        private System.Windows.Forms.Button btnCVFolder;
        private System.Windows.Forms.Label lblCandidateFolder;
        private System.Windows.Forms.Button btnStartEvaluation;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label lblPythonFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClearOutput;
    }
}

