using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HTMLBlockGenerator
{
    public partial class Form1 : Form
    {
        public Converter converter = new Converter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open csv file";
            openFileDialog.Filter = "csv files (*csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                filepath1.Text = filepath;
                filepath1.Visible = true;
                filepath1.BackColor = Color.Azure;
                richTextBox1.Text = File.ReadAllText(filepath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                filepath2.Text = filepath;
                filepath2.Visible = true;
                filepath2.BackColor = Color.Azure;
                richTextBox2.Text = File.ReadAllText(filepath);
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            richTextBox3.Lines = converter.Convert(richTextBox1.Lines, richTextBox2.Lines);
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox3.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Title = "Save generated file";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|html files (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
                {
                    for (int i = 0; i < richTextBox3.Lines.Length; i++)
                    {
                        writer.WriteLine(richTextBox3.Lines[i]);
                    }
                }
            }
        }

        private void CheckTextBoxes()
        {
            if (richTextBox1.Text.Trim().Length > 0 && richTextBox1.Text != "Open a csv file to use.")
            {
                if (richTextBox2.Text.Trim().Length > 0 && richTextBox2.Text != "Open a template or start typing one.")
                {
                    generate.Enabled = true;
                }
                else
                {
                    generate.Enabled = false;
                }
            }
            else
            {
                generate.Enabled = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim().Length > 0 && richTextBox1.Text != "Open a csv file to use.")
            {
                richTextBox1.ForeColor = Color.Black;
            }
            CheckTextBoxes();
        }


        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Open a csv file to use.")
            {
                richTextBox1.Text = "";
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Open a csv file to use.";
                richTextBox1.ForeColor = Color.Gray;
            }
            else
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Trim().Length > 0 && richTextBox2.Text != "Open a template or start typing one.")
            {
                richTextBox2.ForeColor = Color.Black;
                save_template.Enabled = true;
                clear_template.Enabled = true;
            }
            else
            {
                save_template.Enabled = false;
                clear_template.Enabled = false;
                filepath2.Text = "";
                filepath2.Visible = false;
            }
            CheckTextBoxes();
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "Open a template or start typing one.")
            {
                richTextBox2.Text = "";
            }
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "")
            {
                richTextBox2.Text = "Open a template or start typing one.";
                richTextBox2.ForeColor = Color.Gray;
            }
            else
            {
                richTextBox2.ForeColor = Color.Black;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox3.Text.Trim().Length > 0)
            {
                copy.Enabled = true;
                save.Enabled = true;
            }
        }

        private void save_template_Click(object sender, EventArgs e)
        {
            if (filepath2.Text == " " || filepath2.Text == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\";
                saveFileDialog.Title = "Save generated file";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|html files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
                    {
                        for (int i = 0; i < richTextBox2.Lines.Length; i++)
                        {
                            writer.WriteLine(richTextBox2.Lines[i]);
                        }
                    }
                    filepath2.Text = saveFileDialog.FileName;
                    filepath2.Visible = true;
                    filepath2.BackColor = Color.Azure;
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filepath2.Text))
                {
                    for (int i = 0; i < richTextBox2.Lines.Length; i++)
                    {
                        writer.WriteLine(richTextBox2.Lines[i]);
                    }
                }
            }
        }

        private void clear_template_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.Text = "Open a template or start typing one.";
            richTextBox2.ForeColor = Color.Gray;
            filepath2.Visible = false;
        }
    }
}
