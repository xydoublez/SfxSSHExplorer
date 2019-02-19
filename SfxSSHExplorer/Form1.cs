
using Renci.SshNet;
using Renci.SshNet.Async;
using Renci.SshNet.Sftp;
using System;
using System.IO;
using System.Windows.Forms;

namespace SfxSSHExplorer
{
    /// <summary>
    /// linux ssh简单文件浏览器
    /// 创建标识： 李志强  2019-02-19 
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            refresh();

        }
        private void refresh()
        {
            try
            {
                tvDir.Nodes.Clear();
                var connectionInfo = new ConnectionInfo(txtIp.Text, int.Parse(txtPort.Text), txtUser.Text, new PasswordAuthenticationMethod(txtUser.Text, txtPassword.Text));
                using (var client = new SftpClient(connectionInfo))
                {
                    client.Connect();
                    var list = client.ListDirectoryAsync(txtPath.Text);

                    TreeNode root = new TreeNode(txtUser.Text + ":根结点");
                    foreach (var item in list.Result)
                    {

                        TreeNode node = new TreeNode(item.Name);
                        node.Tag = item;
                        node.ToolTipText = "Length:" + item.Length + "LastAccessTime:" + item.LastAccessTime + "owner:" + item.UserId + "groupId:" + item.GroupId;
                        if (item.IsDirectory)
                        {
                            node.ImageIndex = 1;
                            node.SelectedImageIndex = 1;
                        }
                        root.Nodes.Add(node);
                    }
                    tvDir.Nodes.Add(root);
                    tvDir.ExpandAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败!" + ex.Message + ex.StackTrace);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void  上传到此文件夹ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "请选择要上传的文件";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SftpFile file = (SftpFile)tvDir.SelectedNode.Tag;
                var destPath = txtPath.Text;
                if (file != null)
                {
                    destPath = file.FullName;
                    if (file.Name == "." || file.Name == "..")
                    {

                        destPath.Replace(".", "");
                    }
                }
                if (destPath == "." || !file.IsDirectory)
                {
                    destPath = (tvDir.Nodes[0].FirstNode.Tag as SftpFile).FullName.Replace(".", "");
                }
                await uploadAsync(file, destPath);
            }

        }
        private async System.Threading.Tasks.Task uploadAsync(SftpFile file,string destPath)
        {
            try
            {
               
                var connectionInfo = new ConnectionInfo(txtIp.Text, int.Parse(txtPort.Text), txtUser.Text, new PasswordAuthenticationMethod(txtUser.Text, txtPassword.Text));
                using (var client = new SftpClient(connectionInfo))
                {
                    client.Connect();
                    using (var localStream = File.OpenRead(openFileDialog1.FileName))
                    {
                        //await client.UploadAsync(localStream, file.Name);
                      
                        System.Diagnostics.Trace.WriteLine("上传进度!");
                        System.Diagnostics.Trace.WriteLine(localStream.Length);
                        this.progressBar1.Show();
                        this.progressBar1.Maximum = (int)localStream.Length;
                        await client.UploadAsync(localStream, destPath + openFileDialog1.SafeFileName, new Action<ulong>((o) =>
                        {
                            System.Diagnostics.Trace.WriteLine(o);
                            this.Invoke(new Action(() =>
                            {
                                this.progressBar1.Value = (int)o;
                                if (o == (ulong)localStream.Length)
                                {
                                    MessageBox.Show("上传完成");
                                    this.progressBar1.Hide();
                                }
                            }));

                        }));
                        refresh();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void viewDir(string dir)
        {
            lvFiles.Items.Clear();
            txtPath.Text = dir;
            var connectionInfo = new ConnectionInfo(txtIp.Text, int.Parse(txtPort.Text), txtUser.Text, new PasswordAuthenticationMethod(txtUser.Text, txtPassword.Text));

            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();
                    var list = client.ListDirectoryAsync(dir);
                    foreach (var item in list.Result)
                    {
                        ListViewItem p = new ListViewItem(item.Name);
                        p.Tag = item;
                        if (item.IsDirectory)
                        {
                            p.ImageIndex = 1;
                        }

                        lvFiles.Items.Add(p);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tvDir_DoubleClick(object sender, EventArgs e)
        {
            
            SftpFile file = (SftpFile)tvDir.SelectedNode.Tag;
            if (file == null) return;
            viewDir(file.FullName);

        }

        private void 删除此文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除此文件？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var connectionInfo = new ConnectionInfo(txtIp.Text, int.Parse(txtPort.Text), txtUser.Text, new PasswordAuthenticationMethod(txtUser.Text, txtPassword.Text));

                using (var client = new SftpClient(connectionInfo))
                {
                    try
                    {
                        client.Connect();
                        SftpFile file = (SftpFile)tvDir.SelectedNode.Tag;
                        if (file.IsRegularFile)
                        {
                            client.Delete(file.FullName);
                            MessageBox.Show("删除成功！");
                            refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败" + ex.Message);
                    }

                }
            }
        }

        private async void 下载此文件ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            SftpFile file = (SftpFile)tvDir.SelectedNode.Tag;
            if (file == null) return;
            this.saveFileDialog1.FileName = file.Name;
            this.saveFileDialog1.Title = "下载文件，保存至";
            this.saveFileDialog1.DefaultExt = System.IO.Path.GetExtension(file.Name);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                await downloadAsync(file, this.saveFileDialog1.FileName);
            }
        }
        private async System.Threading.Tasks.Task downloadAsync(SftpFile file,string destFile)
        {
            var connectionInfo = new ConnectionInfo(txtIp.Text, int.Parse(txtPort.Text), txtUser.Text, new PasswordAuthenticationMethod(txtUser.Text, txtPassword.Text));

            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();

                    if (file.IsRegularFile)
                    {

                        using (var saveFile = File.OpenWrite(destFile))
                        {
                            this.progressBar1.Maximum = (int)file.Length;
                            this.progressBar1.Show();
                            await client.DownloadAsync(file.FullName, saveFile, new Action<ulong>((o) =>
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.progressBar1.Value = (int) o;
                                    if ((ulong)file.Length == o)
                                    {
                                        MessageBox.Show("下载完成!");
                                        this.progressBar1.Hide();
                                    }
                                }));
                            }));

                        }
                    }
                    else
                    {
                        MessageBox.Show("只允许下载单个文件！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("下载失败" + ex.Message);
                }

            }
        }

        private void lvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SftpFile file = lvFiles.FocusedItem.Tag as SftpFile;
            viewDir(file.FullName);

        }
    }
}
