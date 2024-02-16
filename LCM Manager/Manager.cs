using System;
using System.Windows.Forms;
using LibGit2Sharp;

namespace LCM_Manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            // Default Utilities
            checkBox1.Checked = true;
            checkBox1.Enabled = false;
            checkBox4.Checked = true;
            checkBox4.Enabled = false;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // Code to handle form load event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any mods are selected
            if (checkBox2.Checked || checkBox3.Checked)
            {
                // Perform installation of the file
                InstallFile();
            }
            else
            {
                // Show a warning message
                MessageBox.Show("You have not installed any mods.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the CheckedChanged event of checkBox2 if needed
        }

        private void InstallFile()
        {
            // Here you can write code to install the file
            // For demonstration purposes, let's just show a message box
            MessageBox.Show("File installed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
