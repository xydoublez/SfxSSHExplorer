namespace SfxSSHExplorer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvDir = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.上传到此文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载此文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除此文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动至ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(56, 19);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 21);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "10.68.5.195";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(813, 26);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(162, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(247, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "22";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(353, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户名：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(448, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "sfx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(554, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(629, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 21);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Sfx371482";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blank.ico");
            this.imageList1.Images.SetKeyName(1, "folder.ico");
            this.imageList1.Images.SetKeyName(2, "f1.ico");
            this.imageList1.Images.SetKeyName(3, "f2.ico");
            this.imageList1.Images.SetKeyName(4, "f3.ico");
            this.imageList1.Images.SetKeyName(5, "f4.ico");
            this.imageList1.Images.SetKeyName(6, "f5.ico");
            this.imageList1.Images.SetKeyName(7, "f6.ico");
            this.imageList1.Images.SetKeyName(8, "f7.ico");
            this.imageList1.Images.SetKeyName(9, "f8.ico");
            this.imageList1.Images.SetKeyName(10, "f9.ico");
            this.imageList1.Images.SetKeyName(11, "f10.ico");
            this.imageList1.Images.SetKeyName(12, "f11.ico");
            this.imageList1.Images.SetKeyName(13, "f12.ico");
            this.imageList1.Images.SetKeyName(14, "f13.ico");
            this.imageList1.Images.SetKeyName(15, "f14.ico");
            // 
            // tvDir
            // 
            this.tvDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDir.ContextMenuStrip = this.contextMenuStrip1;
            this.tvDir.ImageIndex = 0;
            this.tvDir.ImageList = this.imageList1;
            this.tvDir.Location = new System.Drawing.Point(3, 5);
            this.tvDir.Name = "tvDir";
            this.tvDir.SelectedImageIndex = 0;
            this.tvDir.Size = new System.Drawing.Size(302, 362);
            this.tvDir.TabIndex = 10;
            this.tvDir.DoubleClick += new System.EventHandler(this.tvDir_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传到此文件夹ToolStripMenuItem,
            this.下载此文件ToolStripMenuItem,
            this.删除此文件ToolStripMenuItem,
            this.移动至ToolStripMenuItem,
            this.属性ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // 上传到此文件夹ToolStripMenuItem
            // 
            this.上传到此文件夹ToolStripMenuItem.Name = "上传到此文件夹ToolStripMenuItem";
            this.上传到此文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.上传到此文件夹ToolStripMenuItem.Text = "上传到此文件夹";
            this.上传到此文件夹ToolStripMenuItem.Click += new System.EventHandler(this.上传到此文件夹ToolStripMenuItem_ClickAsync);
            // 
            // 下载此文件ToolStripMenuItem
            // 
            this.下载此文件ToolStripMenuItem.Name = "下载此文件ToolStripMenuItem";
            this.下载此文件ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.下载此文件ToolStripMenuItem.Text = "下载此文件";
            this.下载此文件ToolStripMenuItem.Click += new System.EventHandler(this.下载此文件ToolStripMenuItem_ClickAsync);
            // 
            // 删除此文件ToolStripMenuItem
            // 
            this.删除此文件ToolStripMenuItem.Name = "删除此文件ToolStripMenuItem";
            this.删除此文件ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除此文件ToolStripMenuItem.Text = "删除此文件";
            this.删除此文件ToolStripMenuItem.Click += new System.EventHandler(this.删除此文件ToolStripMenuItem_Click);
            // 
            // 移动至ToolStripMenuItem
            // 
            this.移动至ToolStripMenuItem.Name = "移动至ToolStripMenuItem";
            this.移动至ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.移动至ToolStripMenuItem.Text = "移动至";
            this.移动至ToolStripMenuItem.Click += new System.EventHandler(this.移动至ToolStripMenuItem_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(92, 66);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(659, 21);
            this.txtPath.TabIndex = 11;
            this.txtPath.Text = ".";
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "所有文件|*.*";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(56, 469);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(779, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "上传到此文件夹";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_ClickAsync);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "下载此文件";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_ClickAsync);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem3.Text = "删除此文件";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem4.Text = "移动至";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(15, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvFiles);
            this.splitContainer1.Size = new System.Drawing.Size(924, 370);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 14;
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.ContextMenuStrip = this.contextMenuStrip2;
            this.lvFiles.Location = new System.Drawing.Point(3, 3);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(591, 360);
            this.lvFiles.SmallImageList = this.imageList1;
            this.lvFiles.TabIndex = 10;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.List;
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "路径：";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.属性ToolStripMenuItem.Text = "属性";
            this.属性ToolStripMenuItem.Click += new System.EventHandler(this.属性ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIp);
            this.Name = "Form1";
            this.Text = "SSHExplorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TreeView tvDir;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 上传到此文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载此文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除此文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移动至ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
    }
}

