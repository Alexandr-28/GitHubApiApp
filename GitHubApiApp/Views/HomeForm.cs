using GitHubApiApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApiApp.Views
{
    public partial class HomeForm : Form
    {
        public static List<FileData> files = new List<FileData>();
        public static List<FileData> photo = new List<FileData>();

        public HomeForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            treeView1.CheckBoxes = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();
            if ((textBox1.Text.Length > 0 && textBox2.Text.Length > 0) || textBox3.Text.Length > 0)
            {

                Directory dir = new Directory();

                if (customRadioButton1.Checked)
                {
                    await Task.Run(() =>
                    {
                        var task = GitHub.GetRepo(textBox1.Text, textBox2.Text, "<myToken>");
                        try
                        {
                            task.Wait();
                            dir = task.Result;
                        }
                        catch (Exception)
                        {
                            return;
                        }
                    });
                }
                else
                {
                    await Task.Run(() =>
                    {
                        var task = GitHub.GetRepo2(textBox3.Text, "<myToken>");
                        try
                        {
                            task.Wait();
                            dir = task.Result;
                        }
                        catch (Exception)
                        {
                            return;
                        }
                    });
                }

                if (dir.subDirs == null)
                {
                    MessageBox.Show("Репозиторий не найден:(");
                    return;
                }


                List<TreeNode> treeNodes = new List<TreeNode>();
                treeView1.Nodes.Add(new TreeNode("All"));
                foreach (var item in dir.files)
                {
                    TreeNode tr = new TreeNode(item.name);
                    tr.Tag = item;
                    treeNodes.Add(tr);
                }


                foreach (var item in dir.subDirs)
                {
                    TreeNode tr = new TreeNode(item.name);
                    tr.Tag = item;
                    treeNodes.Add(tr);
                }



                treeView1.Nodes[0].Nodes.AddRange(treeNodes.ToArray());

                var allNodes = treeView1.GetAllNodes().Where(t => t.Text != "All").ToList();


                for (int i = 0; i < allNodes.Count; i++)
                {
                    if (allNodes[i].Tag != null && allNodes[i].Tag.GetType() != typeof(FileData))
                    {
                        Directory direct = allNodes[i].Tag as Directory;

                        foreach (var innerItem in direct.files)
                        {
                            allNodes[i].Nodes.Add(new TreeNode(innerItem.name) { Tag = innerItem });
                        }
                        foreach (var innerItem in direct.subDirs)
                        {
                            allNodes[i].Nodes.Add(new TreeNode(innerItem.name) { Tag = innerItem });
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Одно или несколько полей не заполнено");
            }
        }

        public bool GetSelectedFiles()
        {
            if (treeView1.GetAllNodes().Where(t => t.Checked).Count() > 0)
            {
                photo = treeView1.GetAllNodes()
                    .Where(t => t.Checked && t.Text != "All" && t.Tag is FileData)
                    .Select(t => t.Tag as FileData)
                    .Where(t => FilesManager.Extension.Any(a => t.name.Contains(a)))
                    .ToList();

                files = treeView1.GetAllNodes()
                    .Where(t => t.Checked && t.Text != "All" && t.Tag is FileData)
                    .Select(t => t.Tag as FileData)
                    .Where(t => FilesManager.Extension.All(a => !t.name.Contains(a)))
                    .ToList();
                return true;
            }
            else
            {
                MessageBox.Show("Файлы не выбраны!");
                return false;
            }
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "All")
                return;

            var allNodes = treeView1.GetAllNodes();

            foreach (TreeNode node in e.Node.Nodes)
            {
                if (node.Tag.GetType() != typeof(FileData) && node.Text != "All")
                {

                    Directory dir = node.Tag as Directory;

                    List<TreeNode> treeNodes = new List<TreeNode>();

                    foreach (var item in dir.files)
                    {
                        TreeNode tr = new TreeNode(item.name)
                        {
                            Tag = item
                        };
                        treeNodes.Add(tr);
                    }

                    foreach (var item in dir.subDirs)
                    {
                        TreeNode tr = new TreeNode(item.name)
                        {
                            Tag = item
                        };
                        treeNodes.Add(tr);
                    }

                    node.Nodes.AddRange(treeNodes.ToArray());
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }
        }

        private void customRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void customRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label3.Visible = true;
            textBox3.Visible = true;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FileData)
            {
                string url = (e.Node.Tag as FileData).url;
                string extension = "";

                for (int i = url.Length - 1; i >= 0; i--)
                {
                    extension += url[i];

                    if (url[i - 1] == '.')
                        break;
                }
                extension = new string(extension.Reverse().ToArray());

                if (FilesManager.Extension.Any(t => t == extension.ToLower()))
                {
                    ShowCode showCode = new ShowCode(null, url);
                    showCode.Show();
                }
                else
                {
                    ShowCode showCode = new ShowCode((e.Node.Tag as FileData).contents, url);
                    showCode.Show();
                }

            }
        }
    }
}
