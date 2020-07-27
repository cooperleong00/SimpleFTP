using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFTP
{
    public partial class MainForm : Form
    {
        Ftp ftp;
        public MainForm()
        {
            InitializeComponent();
            foreach(string f in GetFiles(ClientTextBox.Text))
            {
                ClientListBox.Items.Add(f);
            }

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string host = HostTextBox.Text;
            string user = UserTextBox.Text;
            string pwd = PasswordTextBox.Text;
            int port = Int32.Parse(PortTextBox.Text);
            ftp = new Ftp(host, user, pwd);
            ServiceTextBox.Text = ftp.cur_path;
            ServiceListBox.Items.Clear();
            foreach (string f in ftp.cur_filelist)
            {
                ServiceListBox.Items.Add(f);
            }
        }

        static IEnumerable<string> GetFiles(string path)
        {
            string[] folders_arr = Directory.GetDirectories(path);
            for (int i = 0; i < folders_arr.Length; i++)
            {
                folders_arr[i] = Path.GetFileName(folders_arr[i]);
            }
            List<string> folders = folders_arr.ToList();

            string[] files_arr = Directory.GetFiles(path);
            for (int i = 0; i < files_arr.Length; i++)
            {
                files_arr[i] = Path.GetFileName(files_arr[i]);
            }
            List<string> files = files_arr.ToList();

            folders.AddRange(files);
            return folders;
        }
    }
    
}
