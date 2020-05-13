using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;


namespace Key_Encryptor
{
    public partial class Form1 : Form
    {



        byte[] abc;
        byte[,] table;




        public Form1()
        {
            InitializeComponent();
        }
        //global variables
        private void Form1_Load(object sender, EventArgs e)
        {


            rbEncrypt.Checked = true;

            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                    

                }

            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = od.FileName;
            }
            string path = @"\\Home\Documents\UnassumingFolder";
            if (Directory.Exists(path))
            {
                return;
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
        }

        //Choose button
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = od.FileName;
            }
        }



        //Start Button
        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(tbPath.Text))
            {
                MessageBox.Show("File does not exist.");
                return;
            }
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Password empty. Please enter your password");
                return;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(tbEmail.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Email. Please enter a valid email address.");
                return;
            }


            // Read file and get key for encrypt/decrypt
            try
            {
                DialogResult ruSure = MessageBox.Show("Are you sure you want to overwrite your file?", "Save?", MessageBoxButtons.YesNo);

                if (ruSure == DialogResult.No)
                {
                    return;
                }



                byte[] fileContent = File.ReadAllBytes(tbPath.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(tbPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];
                //string passLength = Convert.ToString(passwordTmp.Length);
                //string fileLength = Convert.ToString(passwordTmp.Length);
                //MessageBox.Show("Pass Length:  " + passwordTmp.Length + ".      File Length:    " + fileLength);




                // Encrypt
                byte[] result = new byte[fileContent.Length];

                if (rbEncrypt.Checked)
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];
                        string iValue = result.ToString();
                        MessageBox.Show(iValue);
                    }

                    if (String.IsNullOrEmpty(tbEmail.Text))
                    {
                        MessageBox.Show("Email empty. Please enter your email");
                        return;
                    }


                    string fileExt = tbPath.Text;
                    int index1 = fileExt.LastIndexOf('.');

                    Random rand = new Random();
                    string savePath = tbSave.Text + rand.Next(1, 99) + fileExt.Substring(index1);
                    File.WriteAllBytes(savePath, result);
                    File.Delete(Path.Combine(tbPath.Text));

                    tbPath.Text = savePath;

                    //Create Email
                    MailMessage mail = new MailMessage("encryptorkey@gmail.com", tbEmail.Text);
                    mail.Subject = "Your Encryption Backup";
                    mail.Body = ("Decryption Key: '" + tbPassword.Text + "'" + Environment.NewLine + "Your file is saved at this location: " + savePath);
                    //Attachment att = new Attachment(tbPath.Text);
                    //mail.Attachments.Add(att);

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.Credentials = new System.Net.NetworkCredential()
                    {
                        UserName = "encryptorkey@gmail.com",
                        Password = "Mygooglepass1Q"
                    };

                    smtpClient.EnableSsl = true;
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                            System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                            System.Security.Cryptography.X509Certificates.X509Chain chain,
                            System.Net.Security.SslPolicyErrors sslPolicyErrors)
                    {
                        return true;
                    };

                    smtpClient.Send(mail);
                    smtpClient.Dispose();
                    MessageBox.Show("File Successfully Encrypted!");
                }



                // Decrypt
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                    string fileExt = tbPath.Text;
                    int index1 = fileExt.LastIndexOf('.');

                    Random rand = new Random();
                    string savePath = tbSaveD.Text + rand.Next(1, 99) + fileExt.Substring(index1);
                    File.WriteAllBytes(savePath, result);
                    File.Delete(Path.Combine(tbPath.Text));
                    MessageBox.Show("File Successfully Decrypted!");
                    tbPath.Text = savePath;



                }

            }
            catch (IOException ioExp)
            {
                MessageBox.Show(ioExp.Message);
                return;
            }
            //"File is in use. Close other program is using this file and try again."
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        public void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
