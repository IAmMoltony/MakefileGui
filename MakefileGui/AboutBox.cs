using System;
using System.Collections.Generic;
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
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("https://github.com/IAmMoltony/MakefileGui");
            Process.Start(psi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
