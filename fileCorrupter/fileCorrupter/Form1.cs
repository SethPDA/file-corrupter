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
        bool isScrambleOn;
        public Form1()
        {
            InitializeComponent();

            isScrambleOn = checkBox1.Checked;
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        string errors;
        string fileRenameErrors;
        void corruptFile(string fileName, string newFileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
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

            // corrupt file
            try
            {
                File.WriteAllBytes(fileName, bytes);
            }
            catch(Exception e)
            {
                errors += e;
            }
            
            

            // jumble filename
            string currentFileName;
            currentFileName = Path.GetFileName(fileName);
            string currentFilePath = fileName.Replace(currentFileName, "");

            if (isScrambleOn == true)
            {
                //string newFileName = Encoding.Default.GetString(HashString(randomSeed(), 20));
                string test = currentFilePath + newFileName;
                //MessageBox.Show(test);

                try
                {
                    File.Move(fileName, currentFilePath + newFileName);
                }
                catch (Exception e)
                {
                    fileRenameErrors += e;
                }

            }
        }

        string[] fileStrings;

        private void fileToCorrupt_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            openFileDialog1.Dispose();
            List<string> fileList = new List<string>();
            fileStrings = null;

            openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog();
            string message = "";


            if (result == DialogResult.OK) // Test result.
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    //message += file + Environment.NewLine;
                    //richTextBox1.Text = message;
                    fileList.Add(file);
                }

                fileStrings = fileList.ToArray();
                for (int i = 0; i < fileStrings.Length; i++)
                {
                    message += fileStrings[i] + Environment.NewLine;
                }

                richTextBox1.Text = message;
                //MessageBox.Show(message);

                //fileName = openFileDialog1.FileName;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void corrupt_Click(object sender, EventArgs e)
        {
            foreach (string currentFile in fileStrings)
            {
                string newFileName = RandomString(30);
                corruptFile(currentFile, newFileName);
            }

            richTextBox1.Clear();
            richTextBox1.Text = "All files are DONE!";

            if(errors != null || fileRenameErrors != null)
            {
                MessageBox.Show(errors);
                MessageBox.Show(fileRenameErrors);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isScrambleOn = checkBox1.Checked;
        }

    }
}
