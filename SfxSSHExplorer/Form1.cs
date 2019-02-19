using Renci.SshNet;
using Renci.SshNet.Async;
using Renci.SshNet.Sftp;
using System;
using System.IO;
using System.Windows.Forms;

namespace SfxSSHExplorer
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private  void  button1_ClickAsync(object sender, EventArgs e)
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
                    var list  = client.ListDirectoryAsync(txtPath.Text);
                    
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
            catch(Exception ex)
            {
                MessageBox.Show("连接失败!" + ex.Message + ex.StackTrace);
            }
        }
        private async System.Threading.Tasks.Task listAsync()
        {
           
            // await a directory listing
            //var listing = await client.ListDirectoryAsync(".");

            //// await a file upload
            //using (var localStream = File.OpenRead("path_to_local_file"))
            //{
            //    await client.UploadAsync(localStream, "upload_path");
            //}

            // disconnect like you normally would
       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private async   void 上传到此文件夹ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "请选择要上传的文件";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SftpFile file = (SftpFile)tvDir.SelectedNode.Tag;
                    var connectionInfo = new ConnectionInfo(txtIp.Text, int.Parse(txtPort.Text), txtUser.Text, new PasswordAuthenticationMethod(txtUser.Text, txtPassword.Text));
                    using (var client = new SftpClient(connectionInfo))
                    {
                        client.Connect();
                        using (var localStream = File.OpenRead(openFileDialog1.FileName))
                        {
                            //await client.UploadAsync(localStream, file.Name);
                            var destPath = txtPath.Text;
                            if (file != null)
                            {
                                destPath = file.FullName;
                                if (file.Name == "." || file.Name == "..")
                                {

                                    destPath.Replace(".", "");
                                }
                            }
                            await client.UploadAsync(localStream, destPath + openFileDialog1.SafeFileName);
                            refresh();


                        }

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            
        }
  
        private void viewDir(string dir)
        {
            lvFiles.Items.Clear();
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
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tvDir_DoubleClick(object sender, EventArgs e)
        {
            SftpFile file = (SftpFile)tvDir.SelectedNode.Tag;
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

        private void 下载此文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Title = "保存文件到";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
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

                            using (var saveFile = File.OpenWrite(this.saveFileDialog1.FileName))
                            {
                                client.DownloadAsync(file.FullName, saveFile);
                                MessageBox.Show("下载成功！");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("下载失败" + ex.Message);
                    }

                }
            }
        }
    }
}
