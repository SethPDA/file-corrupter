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

namespace fileCorrupter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void corruptFile(string fileName)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(fileName);
            byte[] oldBytes = bytes;
            Random rnd = new Random();
            int num = rnd.Next(0, 255);
           
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] % 2 == 0)
                {
                    bytes[i] = (byte)rnd.Next(0, (int)(bytes[i] * 1.618 < 256.0 ? bytes[i] * 1.618 : 255));
                }
            }

            File.WriteAllBytes(fileName + "1.pdf", bytes);
        }

        string fileName = "";
        private void fileToCorrupt_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                fileName = openFileDialog1.FileName;
                richTextBox1.Text = fileName + " OKAY";
                
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void corrupt_Click(object sender, EventArgs e)
        {
            corruptFile(fileName);
            richTextBox1.Clear();
            richTextBox1.Text = "DONE!";
        }
    }
}
