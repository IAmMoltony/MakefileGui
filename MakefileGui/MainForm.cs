using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MakefileGui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string GetMakeArguments()
        {
            // get makefile name
            // if user didn't specify, go with 'Makefile'
            string makefileName = "Makefile";
            if (makefileTextBox.Text.Count() != 0)
                makefileName = makefileTextBox.Text;

            StringBuilder builder = new StringBuilder();
            builder.Append($"{targetTextBox.Text} -f {makefileName}");

            // extra vars
            foreach (string line in extraVarsList.Items)
            {
                builder.Append($"{line} ");
            }

            return builder.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // this is bad but i couldn't care less
            CheckForIllegalCrossThreadCalls = false;
        }

        private void wdBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the folder where your Makefile is located.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                wdTextBox.Text = dialog.SelectedPath;
            }
        }

        private void extraVarAddButton_Click(object sender, EventArgs e)
        {
            extraVarsList.Items.Add($"{extraVarNameTextBox.Text}={extraVarValueTextBox.Text}");
            extraVarNameTextBox.Clear();
            extraVarValueTextBox.Clear();
        }

        private void removeSelectedExtraVarButton_Click(object sender, EventArgs e)
        {
            extraVarsList.Items.RemoveAt(extraVarsList.SelectedIndex);
        }

        private void MakeSentOutput(object sender, DataReceivedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                makeOutput.AppendText(args.Data);
            }
        }

        private void MakeExited(object sender, EventArgs args)
        {
            makeOutput.AppendText($"{Environment.NewLine}Exited with code {((Process)sender).ExitCode}");
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            // get make arguments
            string makeArguments = GetMakeArguments();

            // display "running command" text
            makeOutput.Clear();
            makeOutput.AppendText($"Running command: make.exe {makeArguments}{Environment.NewLine}");

            Process makeProcess = new Process();
            makeProcess.StartInfo.FileName = "make.exe"; // program name
            makeProcess.StartInfo.Arguments = makeArguments; // arguments
            makeProcess.StartInfo.WorkingDirectory = wdTextBox.Text; // wd
            makeProcess.StartInfo.CreateNoWindow = true; // dont create command prompt window
            makeProcess.StartInfo.RedirectStandardOutput = true; // redirect stdout
            makeProcess.StartInfo.RedirectStandardError = true; // redirect stderr
            makeProcess.StartInfo.UseShellExecute = false; // dont use shell execute
            makeProcess.EnableRaisingEvents = true; // enable raising events
            makeProcess.OutputDataReceived += MakeSentOutput; // hook up stdout handler
            makeProcess.ErrorDataReceived += MakeSentOutput; // hook up stderr handler
            makeProcess.Exited += MakeExited; // hook up exit handler
            makeProcess.Start(); // start the process
            makeProcess.BeginOutputReadLine();
            makeProcess.BeginErrorReadLine();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }
    }
}
