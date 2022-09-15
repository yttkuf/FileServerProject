using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileServerProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gotoAutorizationButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AutorizationForm form = new AutorizationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form.FormBorderStyle = FormBorderStyle.None;    
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void gotoRegistrationButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RegistrationForm form = new RegistrationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void gotoRecoverAccButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RecoverAccountForm form = new RecoverAccountForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(form);
            form.Show();
        }
    }
}
