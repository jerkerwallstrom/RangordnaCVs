using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RangordnaCVs
{
    public partial class Form1 : Form
    {
        private string keywordFile = "C:\\Dev\\TestData\\weightedkeywords.txt";
        private string jobdescFile = "C:\\Dev\\TestData\\jobdesc.txt";
        private string cvFolder = "C:\\Dev\\TestData\\CV";
        private string PythonexePath = @"C:\Dev\Python\RangordnaCV\dist\RangordnaCV.exe";
        private string deflogFile = "RangordnaCV_log.docx";
        private string logFile = "";

        public Form1()
        {
            InitializeComponent();
            string exePath = AppContext.BaseDirectory;
            lblPythonFile.Text = exePath;
            string pyFileName = Path.GetFileName(PythonexePath);
            string tmpPython = exePath + pyFileName;
            if (File.Exists(tmpPython))
            {
                PythonexePath = tmpPython;
            }
            else
            {
                PythonexePath = SelectFile(PythonexePath, "Välj exe-fil för rangordning (python made!)");
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            deflogFile = Path.Combine(desktopPath, deflogFile);
            logFile = FixLogFile(deflogFile);
            lblPythonFile.Text = PythonexePath;
            InitDefaultPath();
        }

        private void InitDefaultPath()
        {
            string exePath = AppContext.BaseDirectory;
            keywordFile = Path.Combine(exePath, "NyckelOrd.txt");
            jobdescFile = Path.Combine(exePath, "Arbetsbeskrivning.txt");
            cvFolder = exePath + "CV";
            lblSelectedCVfolder.Text = cvFolder;
            lblKeywordFile.Text = keywordFile;
            lblAssignmentDesc.Text = jobdescFile;
        }

        private string FixLogFile(string aLogFile)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            aLogFile = Path.Combine(desktopPath, aLogFile);
            //if (File.Exists(aLogFile))
            //{
            //    File.Delete(aLogFile);
            //}
            int counter = 0;
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(aLogFile);
            string ext = Path.GetExtension(aLogFile);
            while (File.Exists(aLogFile))
            {
                counter++;
                string dir = Path.GetDirectoryName(aLogFile);
                aLogFile = Path.Combine(dir, fileNameWithoutExt + "_" + counter.ToString() + ext);
            }
            return aLogFile;
        }

        private void btnKeyWord_Click(object sender, EventArgs e)
        {
            keywordFile = SelectFile(keywordFile, "Välj fil med nyckelord");
            lblKeywordFile.Text = keywordFile;
        }

        private string SelectFile(string defFile, string header)
        {
            openFileDialog1.Title = header;
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.FileName = defFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return defFile;
        }

        private void btnAssignmentDesc_Click(object sender, EventArgs e)
        {
            jobdescFile = SelectFile(jobdescFile, "Välj fil för arbetsbeskrivning");
            lblAssignmentDesc.Text = jobdescFile;
        }

        private void btnCVFolder_Click(object sender, EventArgs e)
        {
            string tmpF = ChooseFolder();
            if (!string.IsNullOrEmpty(tmpF))
            {
                cvFolder = tmpF;
                lblSelectedCVfolder.Text = cvFolder;
            }
        }

        private string ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            return "";
        }

        private bool FileExists(string path)
        {
            return File.Exists(path);
        }

        private bool ValidateFiles()
        {
            if (!FileExists(PythonexePath)) return false;
            if (!FileExists(keywordFile)) return false;
            if (!FileExists(jobdescFile)) return false;
            if (!Directory.Exists(cvFolder)) return false;
            return true;
        }
        private async void btnStartEvaluation_Click(object sender, EventArgs e)
        {
            logFile = FixLogFile(deflogFile);
            if (!ValidateFiles())
            {
                MessageBox.Show("Kontrollera att alla filer och mappar är valda korrekt.");
                return;
            }
            progressBar1.Visible = true;
            this.UseWaitCursor = true;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string output = await Task.Run(() => StartPythonAsExeAndGetOutput());
                textBoxOutput.Text = output; // runs on UI thread
            }
            finally
            {
                this.UseWaitCursor = false;
                Cursor.Current = Cursors.Default;
                progressBar1.Visible = false;
            }
            textBoxOutput.Text += $"\r\n";
            textBoxOutput.Text += $"\r\nDetaljer finns i filen: {logFile}";
        }

        // File: Form1.cs
        private string StartPythonAsExeAndGetOutput()
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = PythonexePath,
                Arguments = $"\"{cvFolder}\" \"{jobdescFile}\" \"{keywordFile}\" \"{logFile}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                if (process == null) return "Failed to start process.";
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (!string.IsNullOrEmpty(errors))
                    output += "\r\nErrors:\r\n" + errors;
                return output;
            }
        }


        private string RunPythonScript() //string pythonExePath, string scriptPath, params string[] args
        {
            string pythonExePath = @"C:\Program Files\Python314\python.exe"; // Ange sökväg till python.exe
            string scriptPath = @"C:\Dev\Python\RangordnaCV\RangordnaCV.py"; // Ange sökväg till ditt Python-skript
            // Bygg argumentsträngen
            string arguments = $"\"{scriptPath}\"";
            //foreach (var arg in args)
            //{
            //    arguments += $" \"{arg}\"";
            //}
            arguments = arguments + $"\"{cvFolder}\" \"{jobdescFile}\" \"{keywordFile}\"";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = pythonExePath,       // t.ex. @"C:\Path\To\python.exe"
                Arguments = arguments,          // script + argument
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(errors))
                {
                    output += "\nErrors:\n" + errors;
                }

                return output;
            }
        }


        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }
    }
}
