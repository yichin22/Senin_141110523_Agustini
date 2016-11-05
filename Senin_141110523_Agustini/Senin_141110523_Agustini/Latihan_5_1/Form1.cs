using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "kenapa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*)";
            saveFileDialog1.DefaultExt = "rtf";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter so = new StreamWriter(saveFileDialog1.FileName);
                    so.Write(richTextBox1.Text);
                    so.Close();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "kenapa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            richTextBox1.Visible = true;
        }
    }
}
