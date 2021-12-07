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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fileToCorrupt
            // 
            this.fileToCorrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToCorrupt.Location = new System.Drawing.Point(12, 21);
            this.fileToCorrupt.Name = "fileToCorrupt";
            this.fileToCorrupt.Size = new System.Drawing.Size(641, 73);
            this.fileToCorrupt.TabIndex = 0;
            this.fileToCorrupt.Text = "Files To Corrupt";
            this.fileToCorrupt.UseVisualStyleBackColor = true;
            this.fileToCorrupt.Click += new System.EventHandler(this.fileToCorrupt_Click);
            // 
            // corrupt
            // 
            this.corrupt.BackColor = System.Drawing.Color.Red;
            this.corrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corrupt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.corrupt.Location = new System.Drawing.Point(195, 310);
            this.corrupt.Name = "corrupt";
            this.corrupt.Size = new System.Drawing.Size(260, 49);
            this.corrupt.TabIndex = 1;
            this.corrupt.Text = "Corrupt";
            this.corrupt.UseVisualStyleBackColor = false;
            this.corrupt.Click += new System.EventHandler(this.corrupt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(641, 181);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(219, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Scramble Name and remove extension?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(665, 372);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.corrupt);
            this.Controls.Add(this.fileToCorrupt);
            this.Name = "Form1";
            this.Text = "File Corrupter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileToCorrupt;
        private System.Windows.Forms.Button corrupt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

