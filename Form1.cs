using RangordnaCVs.Dialogs;
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
using System.Text.Json;

namespace RangordnaCVs
{
    public partial class Form1 : Form
    {
        private string keywordFile = "C:\\Dev\\TestData\\weightedkeywords.txt";
        private string jobdescFile = ""; //" C:\\Dev\\TestData\\jobdesc.txt";
        private string cvFolder = "C:\\Dev\\TestData\\CV";
        private string PythonexePath = @"C:\Dev\VisualStudio\RangordnaCVs\Python\dist\RangordnaCV.exe";
        private string language = "sv";
        private string deflogFile = "RangordnaCV_log.docx";
        private string logFile = "";

        public Form1()
        {
            InitializeComponent();
            string exePath = AppContext.BaseDirectory;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            deflogFile = Path.Combine(desktopPath, deflogFile);
            logFile = FixLogFile(deflogFile);
            LoadSettings();
            InitDefaultPath();
            cbLanuage.SelectedIndex = 0;

            if (!File.Exists(PythonexePath))
            {
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
            }
            lblPythonFile.Text = PythonexePath;
        }

        private void LoadSettings()
        {
            string JsonString = Properties.Settings.Default.MyString;
            if (!String.IsNullOrEmpty(JsonString))
            {
                var loaded = JsonSerializer.Deserialize<Dictionary<string, string>>(JsonString);
                if (loaded.TryGetValue("pythonFile", out string tmpPython))
                    PythonexePath = tmpPython;
                if (loaded.TryGetValue("cvPath", out string tmpCVPath))
                    cvFolder = tmpCVPath;
                if (loaded.TryGetValue("jobDesc", out string tmpJobDesc))
                    jobdescFile = tmpJobDesc;
                if (loaded.TryGetValue("keyWord", out string tmpKeyword))
                    keywordFile = tmpKeyword;
            }

        }

        private void SaveSettings()
        {
            var data = new { pythonFile = PythonexePath, cvPath = cvFolder, jobDesc = jobdescFile, keyWord = keywordFile };
            string tmp = JsonSerializer.Serialize(data);
            Properties.Settings.Default.MyString = tmp;
            Properties.Settings.Default.Save();
            //keywordFile = Properties.Settings.Default.keywordFile;
            //jobdescFile = Properties.Settings.Default.jobdescFile;
            //cvFolder = Properties.Settings.Default.cvFolder;
            //PythonexePath = Properties.Settings.Default.PythonexePath;
        }

        private void InitDefaultPath()
        {
            string exePath = AppContext.BaseDirectory;
            if (!FileExists(keywordFile))
            {
                keywordFile = Path.Combine(exePath, "NyckelOrd.txt");
            }
            if (!FileExists(jobdescFile))
            {
                jobdescFile = Path.Combine(exePath, "Arbetsbeskrivning.txt");
            }
            if (!Path.Exists(cvFolder))
            {
                cvFolder = exePath + "CV";
            }
            lblSelectedCVfolder.Text = cvFolder;
            lblKeywordFile.Text = keywordFile;
            lblJobDescFile.Text = jobdescFile;
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
            string defExt = Path.GetExtension(defFile);
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(defFile);
            if (String.IsNullOrEmpty(defExt))
            {
                openFileDialog1.DefaultExt = ".txt";
            }
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
            lblJobDescFile.Text = jobdescFile;
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
            language = "sv";
            if (cbLanuage.SelectedIndex >= 0)
            {
                language = cbLanuage.Text;
            }

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
                Arguments = $"\"{cvFolder}\" \"{jobdescFile}\" \"{keywordFile}\" \"{language}\" \"{logFile}\"",
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

        private void btnEditDesc_Click(object sender, EventArgs e)
        {
            EditDescForm editDescForm = new EditDescForm();
            editDescForm.SetDescFile(jobdescFile);
            if (editDescForm.ShowDialog() == DialogResult.OK)
            {
                jobdescFile = editDescForm.GetDescFile();
                lblJobDescFile.Text = jobdescFile;
            }
        }

        private void btnSetKeyword_Click(object sender, EventArgs e)
        {
            EditDescForm editDescForm = new EditDescForm();
            editDescForm.SetDescFile(keywordFile);
            if (editDescForm.ShowDialog() == DialogResult.OK)
            {
                keywordFile = editDescForm.GetDescFile();
                lblKeywordFile.Text = keywordFile;
            }

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
