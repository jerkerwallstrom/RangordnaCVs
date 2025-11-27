using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RangordnaCVs.Dialogs
{
    public partial class EditDescForm : Form
    {
        private string descriptionFile = "";
        public EditDescForm()
        {
            InitializeComponent();
        }
        public void SetDescFile(string desc)
        {
            descriptionFile = desc;
            if (File.Exists(descriptionFile))
            {
                LoadDescription();
            }
        }

        private void LoadDescription()
        {
            string descText = System.IO.File.ReadAllText(descriptionFile);
            txtDescription.Text = descText;
            UnselectDescription();
        }

        // Add this inside the EditDescForm class
        private void UnselectDescription()
        {
            // If txtDescription is a TextBox/TextBoxBase:
            txtDescription.SelectionLength = 0;
            // Place caret at end (optional)
            txtDescription.SelectionStart = txtDescription.TextLength;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(descriptionFile))
            {
                this.DialogResult = DialogResult.OK;
                string descText = txtDescription.Text;
                System.IO.File.WriteAllText(descriptionFile, descText);
                Close();
            }
            else
            {
                btnSaveAs_Click(sender, e);
            }
        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            string descText = txtDescription.Text;
            saveFileDialog1.Title = "Spara arbetsbeskrivning";
            saveFileDialog1.DefaultExt = ".txt";
            if (File.Exists(descriptionFile))
            {
                saveFileDialog1.FileName = descriptionFile;
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(descriptionFile);
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                descriptionFile = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(descriptionFile, descText);
                Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        internal string GetDescFile()
        {
            return descriptionFile;
        }

    }
}
