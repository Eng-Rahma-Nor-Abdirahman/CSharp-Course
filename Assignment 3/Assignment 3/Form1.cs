
using System;
using System.IO;
using System.Windows.Forms;

namespace FileManagementSystem
{
    public partial class Form1 : Form
    {
        // File location
        string filePath = Path.Combine(
            Application.StartupPath, "index.txt");

        public Form1()
        {
            InitializeComponent();

            btnCreate.Click += btnCreate_Click;
            btnRead.Click += btnRead_Click;
            btnAppend.Click += btnAppend_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnOpen.Click += btnOpen_Click;
        }

        // Create a new file
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writingFile =
                    File.CreateText(filePath))
                {
                    writingFile.WriteLine(txtContent.Text);
                }

                MessageBox.Show("File created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Read the file
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File does not exist!");
                    return;
                }

                lstFileContents.Items.Clear();

                using (StreamReader readingFile =
                    File.OpenText(filePath))
                {
                    string line;

                    while (readingFile.EndOfStream == false)
                    {
                        line = readingFile.ReadLine();
                        lstFileContents.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Append new data
        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writingFile =
                    File.AppendText(filePath))
                {
                    writingFile.WriteLine(txtContent.Text);
                }

                MessageBox.Show("Data appended successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Delete the file
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    lstFileContents.Items.Clear();

                    MessageBox.Show("File deleted successfully!");
                }
                else
                {
                    MessageBox.Show("File does not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clear the screen
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            lstFileContents.Items.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFile.FileName;

                    txtContent.Text = File.ReadAllText(filePath);
                }
            }
        }
        }
}
