
namespace HTMLBlockGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.select1 = new System.Windows.Forms.Button();
            this.select2 = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.filepath1 = new System.Windows.Forms.Label();
            this.filepath2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.save_template = new System.Windows.Forms.Button();
            this.clear_template = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(145, 301);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(102, 23);
            this.select1.TabIndex = 0;
            this.select1.Text = "Open csv file";
            this.select1.UseVisualStyleBackColor = true;
            this.select1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select2
            // 
            this.select2.Location = new System.Drawing.Point(34, 645);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(102, 23);
            this.select2.TabIndex = 1;
            this.select2.Text = "Open template";
            this.select2.UseVisualStyleBackColor = true;
            this.select2.Click += new System.EventHandler(this.button2_Click);
            // 
            // generate
            // 
            this.generate.Enabled = false;
            this.generate.Location = new System.Drawing.Point(399, 304);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 58);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // filepath1
            // 
            this.filepath1.AutoSize = true;
            this.filepath1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filepath1.ForeColor = System.Drawing.Color.Black;
            this.filepath1.Location = new System.Drawing.Point(11, 7);
            this.filepath1.Name = "filepath1";
            this.filepath1.Size = new System.Drawing.Size(10, 15);
            this.filepath1.TabIndex = 3;
            this.filepath1.Text = " ";
            this.filepath1.Visible = false;
            // 
            // filepath2
            // 
            this.filepath2.AutoSize = true;
            this.filepath2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filepath2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filepath2.Location = new System.Drawing.Point(11, 353);
            this.filepath2.Name = "filepath2";
            this.filepath2.Size = new System.Drawing.Size(10, 15);
            this.filepath2.TabIndex = 4;
            this.filepath2.Text = " ";
            this.filepath2.Visible = false;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(788, 645);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(78, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save output";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output:";
            // 
            // copy
            // 
            this.copy.Enabled = false;
            this.copy.Location = new System.Drawing.Point(648, 645);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(83, 23);
            this.copy.TabIndex = 12;
            this.copy.Text = "Copy output";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.richTextBox1.Location = new System.Drawing.Point(11, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(374, 270);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Open a csv file to use.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // richTextBox2
            // 
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.richTextBox2.Location = new System.Drawing.Point(11, 371);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(374, 270);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "Open a template or start typing one.";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.richTextBox2.Enter += new System.EventHandler(this.richTextBox2_Enter);
            this.richTextBox2.Leave += new System.EventHandler(this.richTextBox2_Leave);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(485, 23);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(518, 616);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // save_template
            // 
            this.save_template.Enabled = false;
            this.save_template.Location = new System.Drawing.Point(156, 645);
            this.save_template.Name = "save_template";
            this.save_template.Size = new System.Drawing.Size(91, 23);
            this.save_template.TabIndex = 18;
            this.save_template.Text = "Save template";
            this.save_template.UseVisualStyleBackColor = true;
            this.save_template.Click += new System.EventHandler(this.save_template_Click);
            // 
            // clear_template
            // 
            this.clear_template.Enabled = false;
            this.clear_template.Location = new System.Drawing.Point(264, 645);
            this.clear_template.Name = "clear_template";
            this.clear_template.Size = new System.Drawing.Size(94, 23);
            this.clear_template.TabIndex = 19;
            this.clear_template.Text = "Clear template";
            this.clear_template.UseVisualStyleBackColor = true;
            this.clear_template.Click += new System.EventHandler(this.clear_template_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.clear_template);
            this.Controls.Add(this.save_template);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.filepath2);
            this.Controls.Add(this.filepath1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.select2);
            this.Controls.Add(this.select1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select1;
        private System.Windows.Forms.Button select2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label filepath1;
        private System.Windows.Forms.Label filepath2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button save_template;
        private System.Windows.Forms.Button clear_template;
    }
}

