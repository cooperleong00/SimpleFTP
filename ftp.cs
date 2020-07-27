using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFTP
{
    

    class Ftp
    {
        public static int FTP_PORT = 21;
        public static int MAXLINE = 8192; //缓冲区大小
        
        public static string CRLF = "\r\n"; //结尾标志

        string host;
        string resp; // 最新服务端响应
        string cur_path; // 当前所在目录
        int port = FTP_PORT;
        int maxline = MAXLINE;
        Socket sock; //控制链路套接字
        Byte[] buffer; //缓冲区
        int buffer_size; // 最新缓冲大小
        int code; // 最新的服务端响应的状态码
        ListBox log_listbox; //用于输出log的listbox控件
        public string[] cur_filelist; // 当前的文件夹及文件名数组


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="host">主机地址</param>
        /// <param name="user">用户名</param>
        /// <param name="passwd">密码，无则为空</param>
        public Ftp(string host = "",string user = "",string passwd = "")
        {
            buffer = new Byte[maxline];
            if (host!=""){
                this.Connect(host);
                if (user != "")
                {
                    this.Login(user, passwd);
                }
            }
        }

        /// <summary>
        /// 连接FTP服务端（控制端）
        /// </summary>
        /// <param name="host">主机名</param>
        /// <param name="port">端口，默认21</param>
        public void Connect(string host="",int port = 0)
        {
            if (host != "")
                this.host = host;
            if (port > 0)
                this.port = port;

            this.sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint host_ep = new IPEndPoint(IPAddress.Parse(host), this.port);
            this.sock.Connect(host_ep);

        }

        /// <summary>
        /// 登录FTP服务端
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="passwd">密码，无则为空</param>
        public void Login(string user = "",string passwd = "")
        {
            SendCMD("USER " + user);
            // 331 用户名正确，需要密码。
            // 230 用户已登录，继续进行。
            if (!(code == 331 || code == 230))
            {
                throw new IOException(resp.Substring(4));
            }
            if (code != 230)
            {
                SendCMD("PASS " + passwd);
                // 200 命令确定。
                if (!(code == 200 || code == 230))
                {
                    throw new IOException(resp.Substring(4));
                }
            }
            PWD();
            cur_filelist = GetFileList(cur_path);
        }

        /// <summary>
        /// 移动到指定目录下
        /// </summary>
        /// <param name="path_name">指定目录</param>
        void CWD(string path_name)
        {
            SendCMD("CWD " + path_name);
            // 250 请求的文件操作正确，已完成。
            if (code != 250)
            {
                throw new IOException(resp.Substring(4));
            }
        }

        /// <summary>
        /// 获取当前所在目录
        /// </summary>
        void PWD()
        {
            SendCMD("PWD");
            // 257 已创建“PATHNAME”。
            if (code != 257)
            {
                throw new IOException(resp.Substring(4));
            }
            //从响应中抽取目录子串
            int path_idx1 = resp.IndexOf('\"'), path_idx2 = resp.LastIndexOf('\"');
            cur_path = resp.Substring(path_idx1+1, path_idx2- path_idx1-1);
        }

        /// <summary>
        /// 向FTP服务端发送命令
        /// </summary>
        /// <param name="cmd">命令</param>
        void SendCMD(string cmd)
        {
            // 需要在结尾添加 \r\n 以及编码为子节数组
            Byte[] cmdBytes = Encoding.Default.GetBytes((cmd + "\r\n").ToCharArray());
            this.sock.Send(cmdBytes, cmdBytes.Length, 0);
            GetResp();
        }

        /// <summary>
        /// 将服务器的响应以及对于的状态码赋给成员变量
        /// </summary>
        void GetResp()
        {
            resp = GetLine();
            code = Int32.Parse(resp.Substring(0, 3));
        }

        /// <summary>
        /// 获取单行服务器的响应
        /// </summary>
        /// <returns>转换为字符串后的响应</returns>
        string GetLine()
        {
            string msg = "";
            while (true)
            {
                buffer_size = this.sock.Receive(this.buffer, maxline, 0);
                msg += Encoding.ASCII.GetString(buffer, 0, buffer_size);
                if (buffer_size < maxline)
                    break;
            }
            string[] msgs = Regex.Split(msg,"\r\n");
            if (msg.Length > 2)
                msg = msgs[msgs.Length - 2];
            else
                msg = msgs[0];

            if (!msg.Substring(3, 1).Equals(" "))
            {
                return GetLine();
            }
            return msg;
        }

        /// <summary>
        /// 获取对应目录下的文件夹及文件名
        /// </summary>
        /// <param name="path">目录</param>
        /// <returns>文件夹及文件名组成的字符串数组</returns>
        public string[] GetFileList(string path)
        {
            Socket data_sock = CreateDataSocket();
            // NLST 返回指定目录的文件名列表
            SendCMD("NLST " + path);
            // 150 文件状态正常，准备打开数据连接。
            // 125 数据连接已打开，正在开始传输。
            if (!(code == 150 || code == 125))
            {
                throw new IOException(resp.Substring(4));
            }
            string msg = "";
            //循环：向缓冲区读取数据，转换格式并附加到字符串msg后，直到读取完
            while (true)
            {
                int data_size = data_sock.Receive(buffer, maxline, 0);
                msg += Encoding.ASCII.GetString(buffer, 0, data_size);
                if (data_size < maxline)
                {
                    break;
                }
            }

            string[] msgs = Regex.Split(msg, "\r\n");
            data_sock.Close();
            GetResp();
            // 226 关闭数据连接。请求的文件操作已成功（例如，传输文件或放弃文件）。
            if (code != 226)
            {
                throw new IOException(resp.Substring(4));
            }
            return msgs;
        }

        /// <summary>
        /// 创建数据链路套接字，与控制链路区别
        /// </summary>
        /// <returns>返回数据链路套接字</returns>
        private Socket CreateDataSocket()
        {
            // 设置服务端进入被动模式
            SendCMD("PASV");
            // 227 进入被动模式(h1,h2,h3,h4,p1,p2)。
            // 服务端提供ip地址：h1.h2.h3.h4 ;提供端口 p1<<8 + p2
            if (code != 227)
                throw new IOException(resp.Substring(4));
            // 获取提供的新端口
            int data_port = Parse227(resp);
            Socket data_s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint dat_ep = new IPEndPoint(IPAddress.Parse(host), data_port);
            try
            {
                data_s.Connect(dat_ep);
            }
            catch
            {
                throw new IOException();
            }
            return data_s;
        }

        /// <summary>
        /// 解析服务端被动模式提供的新ip及端口
        /// 通常ip不会变
        /// </summary>
        /// <param name="_resp">待解析的响应</param>
        /// <returns>新的数据传输用接口</returns>
        private int Parse227(string _resp)
        {
            Regex re227 = new Regex(@"(\d+),(\d+),(\d+),(\d+),(\d+),(\d+)");
            MatchCollection m = re227.Matches(_resp, 0);
            string[] group = m[0].Value.Split(',');
            return Int32.Parse(group[4])*256 + Int32.Parse(group[5]);
        }

        public void Download(string file_name)
        {

        }

        public void Upload(string file_name)
        {

        }

        /// <summary>
        /// 设置输出log的listbox控件
        /// </summary>
        /// <param name="listBox"></param>
        void SetLogListbox(ref ListBox listBox)
        {
            this.log_listbox = listBox;
        }

        /// <summary>
        /// 输出log到UI中，而不是控制台
        /// </summary>
        /// <param name="str"></param>
        void PrintLine(string str)
        {
            this.log_listbox.Items.Add(str);
        }
    }
}
