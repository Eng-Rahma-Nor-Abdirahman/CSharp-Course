using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seesion_Night_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Prepare DialogResult
            DialogResult results;

            // Step 2: Open the file dialog
            results = openFileDialog1.ShowDialog();

            // Step 3: Check the user's selection
            if (results == DialogResult.OK)
            {
                // Step 4: Open the selected file
                StreamReader reads =
                    File.OpenText(openFileDialog1.FileName);

                // Step 5: Read the file line by line
                string lines;

                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();

                    // Step 6: Display each line in the ListBox
                    listBox1.Items.Add(lines);
                }

                // Step 7: Close the file
                reads.Close();
            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Waa la kansalay codsiga.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Step 1: Prepare DialogResult
            DialogResult results;

            // Step 2: Open the Save File Dialog
            results = saveFileDialog1.ShowDialog();

            // Step 3: Check the user's selection
            if (results == DialogResult.OK)
            {
                // Step 4: Create the file
                StreamWriter writes =
                    File.CreateText(saveFileDialog1.FileName);

                // Step 5: Write data into the file
                writes.WriteLine("CA246 Waa dhaceen C#");
                writes.WriteLine("CA246 Waa dhaceen C#");

                // Step 6: Close the file
                writes.Close();

                MessageBox.Show("File-ka waa la kaydiyey.");
            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Kaydinta waa la kansalay.");
            }
        }

    }
}

