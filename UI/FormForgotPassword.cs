﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class FormForgotPassword : Form
    {
        string hash = "@HR0";
        int id;
        string password;
        private ClassUsers users = new ClassUsers();
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataTable getuser = users.getUserByEmail(textBoxEmail.Text);
            if (getuser.Rows.Count < 1)
            {
                MessageBox.Show("El correo no esta registrado");
            }
            else
            {

                foreach (DataRow item in getuser.Rows)
                {
                    id = Convert.ToInt32(item.Field<int>(0));
                }

                byte[] data = UTF8Encoding.UTF8.GetBytes("QUIROFANOSHRO" + id.ToString());
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        password = Convert.ToBase64String(results, 0, results.Length);
                    }
                }
                string userName = "QHRO"+id.ToString();
                string response = users.restoreUserPass(id,userName,password);
                if (response.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(response);
                }
                else{
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                    msg.To.Add(textBoxEmail.Text);
                    msg.Subject = "SOLICITUD DE RESTABLECIMIENTO DE USUARIO";
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;

                    msg.Body = "NOMBRE DE USUARIO: " + userName + "\nCONTRASEÑA: QUIROFANOSHRO" + id.ToString();
                    msg.BodyEncoding = System.Text.Encoding.UTF8;

                    msg.From = new System.Net.Mail.MailAddress("peltzjr11@gmail.com");

                    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("peltzjr11@gmail.com", "clinshesh32");

                    client.Port = 587;
                    client.EnableSsl = true;

                    client.Host = "smtp.gmail.com";

                    try
                    {
                        client.Send(msg);
                        MessageBox.Show(response);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al enviar");
                    }
                }
                
            }
        }
    }
}
