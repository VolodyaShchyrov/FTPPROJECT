using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace FtpProjectVova
{
    public partial class Form1: Form
    {
        //public string path = @"C:\Users\VOVCHIK\OneDrive\Desktop\vova\text1.txt";
        public string path = @"";
        public string ftpLink = "";/** ftp://ftp.gnu.org/gnu/ */
        public string userLogin = "";
        public string userPassw = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("All what you need for this App:\n1) Link to FTP server on http/https request\n2) User login and password(It is recommended to leave the blank from the application)\n3) Local addressing to a text file(recommend to create)\n\t-You can create Text file iin app");
        }

        private void button2_Click(object sender, EventArgs e)//create text file
        {
            try
            {
                FileStream file = new FileStream(createFileTextBox.Text, FileMode.Append);
                StreamWriter stream = new StreamWriter(file);


                stream.Close();
                file.Close();
                
                MessageBox.Show("File created");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }   
        }

        private void createFileTextBox_TextChanged(object sender, EventArgs e)
        {
            //path = createFileTextBox.Text;
        }

        private void ftpString_TextChanged(object sender, EventArgs e)
        {
            //ftpLink = ftpString.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//user login 
        {
            //userLogin = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)// user password
        {
            //userPassw = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ftpLink = ftpString.Text;

            try 
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpLink);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                ///////
                request.Timeout = 1500;

                request.UsePassive = true;
                ///////
                request.Credentials = new NetworkCredential(userLogin, userPassw);


                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    for (int i = 0; i < 30; i++)
                    {
                        File.AppendAllText(path, "#");
                    }
                    File.AppendAllText(path, "\n\n");
                    string timeDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss");

                    File.AppendAllText(path, "Date and time: "+timeDate + Environment.NewLine);
                    int count = 0;
                    while((line = reader.ReadLine())!= null)
                    {
                        for(int i = 0;i < 30;i++)
                        {
                            File.AppendAllText(path,"-");
                        }
                        File.AppendAllText(path,$"   {++count}.----" + line + "\n");
                    }
                    MessageBox.Show("All files name and derictories on .txt file.");


                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
                


        }

        private void txtButtonCon_Click(object sender, EventArgs e)
        {
            try
            {
                path = pathConString.Text;
                MessageBox.Show("Connected");
                File.AppendAllText(path,"------------\nFile connected\n------------");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void loginSaveButt_Click(object sender, EventArgs e)
        {
            try
            {
                userLogin = textBox2.Text;
                userPassw = textBox3.Text;
                MessageBox.Show("Login and password saved");
            }
            catch ( Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}