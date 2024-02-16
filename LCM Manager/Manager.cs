using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace LCM_Manager
{
    public partial class Manager : Form
    {
        private string steamInstallationPath = "";

        public Manager()
        {
            InitializeComponent();
            // Default Utilities
            checkBox1.Checked = true;
            checkBox1.Enabled = false;
            checkBox4.Checked = true;
            checkBox4.Enabled = false;
            textBox1.Enabled = false;
            // Find and display Steam installation path
            FindAndDisplayInstallationPath();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void InstallFile()
        {
            // Here you can write code to install the file
            // For demonstration purposes, let's just show a message box
            MessageBox.Show("File installed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FindAndDisplayInstallationPath()
        {
            // Look for Steam installation path in the registry
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Valve\Steam"))
            {
                if (key != null)
                {
                    object value = key.GetValue("InstallPath");
                    if (value != null)
                    {
                        steamInstallationPath = value.ToString();
                    }
                }
            }

            if (string.IsNullOrEmpty(steamInstallationPath))
            {
                MessageBox.Show("Steam installation path not found in the registry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lethalCompanyPath = Path.Combine(steamInstallationPath, "steamapps", "common", "Lethal Company");

            if (Directory.Exists(lethalCompanyPath))
            {
                // Display the Lethal Company installation path in the text box
                textBox1.Text = lethalCompanyPath;
            }
            else
            {
                MessageBox.Show("Lethal Company installation directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the CheckedChanged event of checkBox2 if needed
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the CheckedChanged event of checkBox3 if needed
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the CheckedChanged event of checkBox1 if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle the Click event of label1 if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle the Click event of label2 if needed
        }
    }
}
