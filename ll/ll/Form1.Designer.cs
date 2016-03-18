namespace ll
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
            this.humtum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.abs = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // humtum
            // 
            this.humtum.Location = new System.Drawing.Point(56, 40);
            this.humtum.Name = "humtum";
            this.humtum.Size = new System.Drawing.Size(111, 73);
            this.humtum.TabIndex = 0;
            this.humtum.Text = "humtum\r\n";
            this.humtum.UseVisualStyleBackColor = true;
            this.humtum.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "order";
            // 
            // abs
            // 
            this.abs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.abs.Location = new System.Drawing.Point(125, 160);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(100, 20);
            this.abs.TabIndex = 2;
            this.abs.Text = "xyz\r\nabs\r\n";
            this.abs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "f"});
            this.comboBox1.Location = new System.Drawing.Point(623, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ll.Properties.Resources._35;
            this.ClientSize = new System.Drawing.Size(773, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.abs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.humtum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button humtum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox abs;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

