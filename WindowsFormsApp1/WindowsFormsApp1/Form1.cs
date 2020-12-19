using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\No.6\Desktop\WindowsFormsApp1\WindowsFormsApp1\webdriver.py";//py文件路径
                string username = textusername.Text.Trim();
                string password = textpassword.Text.Trim();

                string hour = texthour.Text.Trim();
                string min = textminute.Text.Trim();
                
                
                StartTest(path, username, password, hour, min);
                


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        public void StartTest(string pathAlg, string username, string password, string hour, string  min)
        {
            

            if (!File.Exists(pathAlg))
            {
                throw new Exception("The file was not found.");
                
            }
            string sArguments = pathAlg;
            sArguments += " " + username + " " + password + " " + hour + " " + min;//Python文件的路径用“/”划分比较常见

           

            Process p = new Process();
            
            


            p.StartInfo.FileName = @"python.exe"; //python的安装路径
            p.StartInfo.Arguments = sArguments;//python命令的参数
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();//启动进程

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


