namespace SimpleFTP
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InfoListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.ServiceBackButton = new System.Windows.Forms.Button();
            this.ServiceTextBox = new System.Windows.Forms.TextBox();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.ClientBackButton = new System.Windows.Forms.Button();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PortTextBox);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.UserTextBox);
            this.panel1.Controls.Add(this.HostTextBox);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 78);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "主机：";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(643, 37);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 21);
            this.PortTextBox.TabIndex = 7;
            this.PortTextBox.Text = "21";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(472, 37);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 21);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(298, 37);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(100, 21);
            this.UserTextBox.TabIndex = 5;
            this.UserTextBox.Text = "local";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(115, 37);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(100, 21);
            this.HostTextBox.TabIndex = 4;
            this.HostTextBox.Text = "192.168.0.110";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(784, 32);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(90, 29);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "连接";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InfoListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 100);
            this.panel2.TabIndex = 1;
            // 
            // InfoListBox
            // 
            this.InfoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoListBox.Enabled = false;
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.ItemHeight = 12;
            this.InfoListBox.Location = new System.Drawing.Point(0, 0);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(1121, 100);
            this.InfoListBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ServiceListBox);
            this.splitContainer1.Panel1.Controls.Add(this.ServiceBackButton);
            this.splitContainer1.Panel1.Controls.Add(this.ServiceTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ClientListBox);
            this.splitContainer1.Panel2.Controls.Add(this.ClientBackButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClientTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 429);
            this.splitContainer1.SplitterDistance = 559;
            this.splitContainer1.TabIndex = 2;
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.ItemHeight = 12;
            this.ServiceListBox.Location = new System.Drawing.Point(0, 44);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.Size = new System.Drawing.Size(559, 385);
            this.ServiceListBox.TabIndex = 2;
            // 
            // ServiceBackButton
            // 
            this.ServiceBackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServiceBackButton.Location = new System.Drawing.Point(0, 21);
            this.ServiceBackButton.Name = "ServiceBackButton";
            this.ServiceBackButton.Size = new System.Drawing.Size(559, 23);
            this.ServiceBackButton.TabIndex = 1;
            this.ServiceBackButton.Text = "返回上级";
            this.ServiceBackButton.UseVisualStyleBackColor = true;
            // 
            // ServiceTextBox
            // 
            this.ServiceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServiceTextBox.Location = new System.Drawing.Point(0, 0);
            this.ServiceTextBox.Name = "ServiceTextBox";
            this.ServiceTextBox.ReadOnly = true;
            this.ServiceTextBox.Size = new System.Drawing.Size(559, 21);
            this.ServiceTextBox.TabIndex = 0;
            // 
            // ClientListBox
            // 
            this.ClientListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 12;
            this.ClientListBox.Location = new System.Drawing.Point(0, 44);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(558, 385);
            this.ClientListBox.TabIndex = 2;
            // 
            // ClientBackButton
            // 
            this.ClientBackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientBackButton.Location = new System.Drawing.Point(0, 21);
            this.ClientBackButton.Name = "ClientBackButton";
            this.ClientBackButton.Size = new System.Drawing.Size(558, 23);
            this.ClientBackButton.TabIndex = 1;
            this.ClientBackButton.Text = "返回上级";
            this.ClientBackButton.UseVisualStyleBackColor = true;
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientTextBox.Location = new System.Drawing.Point(0, 0);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(558, 21);
            this.ClientTextBox.TabIndex = 0;
            this.ClientTextBox.Text = "C:\\";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 607);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "SimpleFTP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.Button ServiceBackButton;
        private System.Windows.Forms.TextBox ServiceTextBox;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Button ClientBackButton;
        private System.Windows.Forms.TextBox ClientTextBox;
        public System.Windows.Forms.ListBox InfoListBox;
    }
}

