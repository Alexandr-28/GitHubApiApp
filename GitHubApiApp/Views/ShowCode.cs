using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GitHubApiApp.Views
{
    public partial class ShowCode : Form
    {
        public ShowCode(string text, string url)
        {
            InitializeComponent();


            if (text != null)
            {
                richTextBox1.BackColor = Color.FromArgb(51, 51, 76);
                richTextBox1.ForeColor = Color.White;
                Font font = new Font(richTextBox1.Text, 12F);
                richTextBox1.Font = font;
                pictureBox1.Visible = false;
                richTextBox1.Visible = true;
                richTextBox1.Text = text;

                List<string> temp = new List<string>();

                for(int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    temp.Add($"{i + 1}   " + richTextBox1.Lines[i] + "\n");
                }

                richTextBox1.Text = null;
                foreach (var item in temp)
                {
                    richTextBox1.Text += item;
                }
            }
            else
            {
                pictureBox1.BackColor = Color.FromArgb(51, 51, 76);
                richTextBox1.Visible = false;
                pictureBox1.Load(url);
            }
        }
    }
}