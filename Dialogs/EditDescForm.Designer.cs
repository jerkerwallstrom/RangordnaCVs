namespace RangordnaCVs.Dialogs
{
    partial class EditDescForm
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
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnSaveAs = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(12, 12);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(656, 598);
            txtDescription.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(486, 628);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(12, 628);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Avbryt";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAs.Location = new Point(576, 628);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(75, 23);
            btnSaveAs.TabIndex = 3;
            btnSaveAs.Text = "Spara som";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // EditDescForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 663);
            Controls.Add(btnSaveAs);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Name = "EditDescForm";
            Text = "EditDescForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;
        private SaveFileDialog saveFileDialog1;
        private Button btnSaveAs;
    }
}