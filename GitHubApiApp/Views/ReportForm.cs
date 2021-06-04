using GitHubApiApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitHubApiApp.Views
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                foreach (var item in Controls)
                {
                    if (item is TextBox)
                    {
                        var tb = item as TextBox;
                        if (tb.Text == "")
                            throw new InvalidOperationException("Поля незаполнены!");
                        else
                            data[$"<{tb.Name}>"] = tb.Text;
                    }
                    else if (item is RichTextBox)
                    {
                        var tb = item as RichTextBox;
                        if (tb.Text == "")
                            throw new InvalidOperationException("Поля незаполнены!");
                        else
                            data[$"<{tb.Name}>"] = tb.Text;
                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var SaveAs = saveFileDialog.FileName;
                        WordApi.CreateWordDocument(System.IO.Path.Combine(Environment.CurrentDirectory, "src.docx"), SaveAs, HomeForm.photo, HomeForm.files, data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
