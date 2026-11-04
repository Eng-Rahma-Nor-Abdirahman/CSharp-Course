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

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writes;
            //create a file to write the data
            writes = File.CreateText("index.txt");

            //proocess the files using writeline method
            writes.Write("hello its me Rahma");

            MessageBox.Show("successfull created");
            //close the file
            writes.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter writes;
            //create a file to write the data
            writes = File.CreateText("index.txt");

            //proocess the files using writeline method
            writes.WriteLine("hello its me Rahma");

            MessageBox.Show("successfull created");


            //close the file
            writes.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            StreamWriter writes;
            //create a file to write the data
            writes = File.CreateText(@"C:\Users\HP\OneDrive\Desktop\CSharp-Course\files\files\index.txt");

            //proocess the files using writeline method
            writes.Write("hello its me Rahma");

            //close the file
            writes.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            //create a file to read the data
            reads=File.OpenText("index.txt");

            //proocess the files using writeline method

            //variable to store the data
            string line;
            line=reads.ReadLine();

            //adding listbox to display the data
            listBox1.Items.Add(line);

            //close the file
            reads.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            //create a file to read the data
            reads = File.OpenText("index.txt");

            //proocess the files using writeline method

            //variable to store the data
            string line;

            while (reads.EndOfStream)
            {
                line = reads.ReadLine();
                //adding listbox to display the data
                listBox1.Items.Add(line);
            }
            //close the file
            reads.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            //create a file to read the data
            reads = File.OpenText("index.txt");

            //proocess the files using writeline method

            //variable to store the data
            char line;

            while (!reads.EndOfStream)
            {
                line = (char)reads.Read();
                //adding listbox to display the data
                listBox1.Items.Add(line);
            }
            //close the file
            reads.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            //create a file to read the data
            reads = File.OpenText("index.txt");

            //proocess the files using writeline method
            string line;
            line = reads.ReadToEnd();
            //adding listbox to display the data
            listBox1.Items.Add(line);
            //close the file
            reads.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            string line;
            line = File.ReadAllText("index.txt");
            //adding listbox to display the data
            listBox1.Items.Add(line);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StreamWriter writes;

            //create a file to write the data
            writes = File.AppendText("index.txt");

            //proocess the files using writeline method
            writes.WriteLine("hello its me Rahma");

            //close the file
            writes.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            File.Delete("index.txt");
            MessageBox.Show("File Deleted");
        }
    }
}
