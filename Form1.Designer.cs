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
            lblKeyWord = new Label();
            btnKeyWord = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblKeywordFile = new Label();
            lblJobDescFile = new Label();
            btnAssignmentDesc = new Button();
            lblAssigment = new Label();
            lblSelectedCVfolder = new Label();
            btnCVFolder = new Button();
            lblCandidateFolder = new Label();
            btnStartEvaluation = new Button();
            textBoxOutput = new TextBox();
            lblPythonFile = new Label();
            progressBar1 = new ProgressBar();
            btnClearOutput = new Button();
            cbLanuage = new ComboBox();
            lblJobDescLang = new Label();
            btnSetKeyword = new Button();
            btnEditDesc = new Button();
            SuspendLayout();
            // 
            // lblKeyWord
            // 
            lblKeyWord.AutoSize = true;
            lblKeyWord.Location = new Point(21, 30);
            lblKeyWord.Margin = new Padding(4, 0, 4, 0);
            lblKeyWord.Name = "lblKeyWord";
            lblKeyWord.Size = new Size(98, 15);
            lblKeyWord.TabIndex = 0;
            lblKeyWord.Text = "Välj nyckelordsfil:";
            // 
            // btnKeyWord
            // 
            btnKeyWord.Location = new Point(131, 24);
            btnKeyWord.Margin = new Padding(4, 3, 4, 3);
            btnKeyWord.Name = "btnKeyWord";
            btnKeyWord.Size = new Size(88, 27);
            btnKeyWord.TabIndex = 1;
            btnKeyWord.Text = "Nyckelord";
            btnKeyWord.UseVisualStyleBackColor = true;
            btnKeyWord.Click += btnKeyWord_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblKeywordFile
            // 
            lblKeywordFile.AutoSize = true;
            lblKeywordFile.Location = new Point(21, 54);
            lblKeywordFile.Margin = new Padding(4, 0, 4, 0);
            lblKeywordFile.Name = "lblKeywordFile";
            lblKeywordFile.Size = new Size(213, 15);
            lblKeywordFile.TabIndex = 2;
            lblKeywordFile.Text = "C:\\Dev\\TestData\\weightedkeywords.txt";
            // 
            // lblJobDescFile
            // 
            lblJobDescFile.AutoSize = true;
            lblJobDescFile.Location = new Point(21, 157);
            lblJobDescFile.Margin = new Padding(4, 0, 4, 0);
            lblJobDescFile.Name = "lblJobDescFile";
            lblJobDescFile.Size = new Size(155, 15);
            lblJobDescFile.TabIndex = 5;
            lblJobDescFile.Text = "C:\\Dev\\TestData\\jobdesc.txt";
            // 
            // btnAssignmentDesc
            // 
            btnAssignmentDesc.Location = new Point(177, 126);
            btnAssignmentDesc.Margin = new Padding(4, 3, 4, 3);
            btnAssignmentDesc.Name = "btnAssignmentDesc";
            btnAssignmentDesc.Size = new Size(142, 27);
            btnAssignmentDesc.TabIndex = 4;
            btnAssignmentDesc.Text = "Uppdragsbeskrivning";
            btnAssignmentDesc.UseVisualStyleBackColor = true;
            btnAssignmentDesc.Click += btnAssignmentDesc_Click;
            // 
            // lblAssigment
            // 
            lblAssigment.AutoSize = true;
            lblAssigment.Location = new Point(21, 132);
            lblAssigment.Margin = new Padding(4, 0, 4, 0);
            lblAssigment.Name = "lblAssigment";
            lblAssigment.Size = new Size(142, 15);
            lblAssigment.TabIndex = 3;
            lblAssigment.Text = "Välj uppdragsbeskrivning:";
            // 
            // lblSelectedCVfolder
            // 
            lblSelectedCVfolder.AutoSize = true;
            lblSelectedCVfolder.Location = new Point(21, 286);
            lblSelectedCVfolder.Margin = new Padding(4, 0, 4, 0);
            lblSelectedCVfolder.Name = "lblSelectedCVfolder";
            lblSelectedCVfolder.Size = new Size(112, 15);
            lblSelectedCVfolder.TabIndex = 8;
            lblSelectedCVfolder.Text = "C:\\Dev\\TestData\\CV";
            // 
            // btnCVFolder
            // 
            btnCVFolder.Location = new Point(177, 256);
            btnCVFolder.Margin = new Padding(4, 3, 4, 3);
            btnCVFolder.Name = "btnCVFolder";
            btnCVFolder.Size = new Size(142, 27);
            btnCVFolder.TabIndex = 7;
            btnCVFolder.Text = "CV katalog";
            btnCVFolder.UseVisualStyleBackColor = true;
            btnCVFolder.Click += btnCVFolder_Click;
            // 
            // lblCandidateFolder
            // 
            lblCandidateFolder.AutoSize = true;
            lblCandidateFolder.Location = new Point(21, 262);
            lblCandidateFolder.Margin = new Padding(4, 0, 4, 0);
            lblCandidateFolder.Name = "lblCandidateFolder";
            lblCandidateFolder.Size = new Size(88, 15);
            lblCandidateFolder.TabIndex = 6;
            lblCandidateFolder.Text = "Välj CV katalog:";
            // 
            // btnStartEvaluation
            // 
            btnStartEvaluation.Location = new Point(21, 365);
            btnStartEvaluation.Margin = new Padding(4, 3, 4, 3);
            btnStartEvaluation.Name = "btnStartEvaluation";
            btnStartEvaluation.Size = new Size(194, 27);
            btnStartEvaluation.TabIndex = 9;
            btnStartEvaluation.Text = "Starta utvärdering";
            btnStartEvaluation.UseVisualStyleBackColor = true;
            btnStartEvaluation.Click += btnStartEvaluation_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutput.Location = new Point(391, 14);
            textBoxOutput.Margin = new Padding(4, 3, 4, 3);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ScrollBars = ScrollBars.Both;
            textBoxOutput.Size = new Size(501, 522);
            textBoxOutput.TabIndex = 10;
            textBoxOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPythonFile
            // 
            lblPythonFile.AutoSize = true;
            lblPythonFile.Location = new Point(21, 521);
            lblPythonFile.Margin = new Padding(4, 0, 4, 0);
            lblPythonFile.Name = "lblPythonFile";
            lblPythonFile.Size = new Size(61, 15);
            lblPythonFile.TabIndex = 11;
            lblPythonFile.Text = "Pythonfile";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 415);
            progressBar1.Margin = new Padding(4, 3, 4, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(190, 27);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 12;
            progressBar1.Visible = false;
            // 
            // btnClearOutput
            // 
            btnClearOutput.Location = new Point(21, 460);
            btnClearOutput.Margin = new Padding(4, 3, 4, 3);
            btnClearOutput.Name = "btnClearOutput";
            btnClearOutput.Size = new Size(99, 27);
            btnClearOutput.TabIndex = 13;
            btnClearOutput.Text = "Rensa resultat";
            btnClearOutput.UseVisualStyleBackColor = true;
            btnClearOutput.Click += btnClearOutput_Click;
            // 
            // cbLanuage
            // 
            cbLanuage.FormattingEnabled = true;
            cbLanuage.Items.AddRange(new object[] { "sv", "en" });
            cbLanuage.Location = new Point(177, 311);
            cbLanuage.Name = "cbLanuage";
            cbLanuage.Size = new Size(121, 23);
            cbLanuage.TabIndex = 14;
            // 
            // lblJobDescLang
            // 
            lblJobDescLang.AutoSize = true;
            lblJobDescLang.Location = new Point(21, 314);
            lblJobDescLang.Name = "lblJobDescLang";
            lblJobDescLang.Size = new Size(54, 15);
            lblJobDescLang.TabIndex = 15;
            lblJobDescLang.Text = "CV Språk";
            // 
            // btnSetKeyword
            // 
            btnSetKeyword.Location = new Point(21, 83);
            btnSetKeyword.Name = "btnSetKeyword";
            btnSetKeyword.Size = new Size(112, 23);
            btnSetKeyword.TabIndex = 16;
            btnSetKeyword.Text = "Sätt nyckelord";
            btnSetKeyword.UseVisualStyleBackColor = true;
            btnSetKeyword.Click += btnSetKeyword_Click;
            // 
            // btnEditDesc
            // 
            btnEditDesc.Location = new Point(21, 189);
            btnEditDesc.Name = "btnEditDesc";
            btnEditDesc.Size = new Size(112, 23);
            btnEditDesc.TabIndex = 17;
            btnEditDesc.Text = "Editera uppdrag";
            btnEditDesc.UseVisualStyleBackColor = true;
            btnEditDesc.Click += btnEditDesc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 562);
            Controls.Add(btnEditDesc);
            Controls.Add(btnSetKeyword);
            Controls.Add(lblJobDescLang);
            Controls.Add(cbLanuage);
            Controls.Add(btnClearOutput);
            Controls.Add(progressBar1);
            Controls.Add(lblPythonFile);
            Controls.Add(textBoxOutput);
            Controls.Add(btnStartEvaluation);
            Controls.Add(lblSelectedCVfolder);
            Controls.Add(btnCVFolder);
            Controls.Add(lblCandidateFolder);
            Controls.Add(lblJobDescFile);
            Controls.Add(btnAssignmentDesc);
            Controls.Add(lblAssigment);
            Controls.Add(lblKeywordFile);
            Controls.Add(btnKeyWord);
            Controls.Add(lblKeyWord);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Leave += Form1_Leave;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyWord;
        private System.Windows.Forms.Button btnKeyWord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblKeywordFile;
        private System.Windows.Forms.Label lblJobDescFile;
        private System.Windows.Forms.Button btnAssignmentDesc;
        private System.Windows.Forms.Label lblAssigment;
        private System.Windows.Forms.Label lblSelectedCVfolder;
        private System.Windows.Forms.Button btnCVFolder;
        private System.Windows.Forms.Label lblCandidateFolder;
        private System.Windows.Forms.Button btnStartEvaluation;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label lblPythonFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClearOutput;
        private ComboBox cbLanuage;
        private Label lblJobDescLang;
        private Button btnSetKeyword;
        private Button btnEditDesc;
    }
}

