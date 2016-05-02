namespace fileCorrupter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileToCorrupt = new System.Windows.Forms.Button();
            this.corrupt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fileToCorrupt
            // 
            this.fileToCorrupt.Location = new System.Drawing.Point(12, 21);
            this.fileToCorrupt.Name = "fileToCorrupt";
            this.fileToCorrupt.Size = new System.Drawing.Size(260, 23);
            this.fileToCorrupt.TabIndex = 0;
            this.fileToCorrupt.Text = "File To Corrupt";
            this.fileToCorrupt.UseVisualStyleBackColor = true;
            this.fileToCorrupt.Click += new System.EventHandler(this.fileToCorrupt_Click);
            // 
            // corrupt
            // 
            this.corrupt.Location = new System.Drawing.Point(12, 196);
            this.corrupt.Name = "corrupt";
            this.corrupt.Size = new System.Drawing.Size(260, 23);
            this.corrupt.TabIndex = 1;
            this.corrupt.Text = "Corrupt";
            this.corrupt.UseVisualStyleBackColor = true;
            this.corrupt.Click += new System.EventHandler(this.corrupt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 52);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(41, 117);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(193, 73);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.corrupt);
            this.Controls.Add(this.fileToCorrupt);
            this.Name = "Form1";
            this.Text = "corrupter ultimatecs.xyz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileToCorrupt;
        private System.Windows.Forms.Button corrupt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

