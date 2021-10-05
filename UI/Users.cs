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
    public partial class Users : Form
    {
        private ClassUsers users = new ClassUsers();

        string userName;
        string hash = "@HR0";
        private ClassServices services = new ClassServices();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable infoRoles = users.GetRoles();
            comboBoxRole.ValueMember = "idrol";
            comboBoxRole.DisplayMember = "nombrerol";
            comboBoxRole.DataSource = infoRoles;

            DataTable infoServices = services.getServices();
            comboBoxServices.ValueMember = "idservicio";
            comboBoxServices.DisplayMember = "nombreservicio";
            comboBoxServices.DataSource = infoServices;
        }

        private void iconButtonCreateAndRequest_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxRole.SelectedValue) == 4)
            {
                //ToUpper().Contains("ERROR")
                 userName= users.addUser(textBoxEmail.Text,Convert.ToInt32(comboBoxRole.SelectedValue),Convert.ToInt32(comboBoxServices.SelectedValue));
            }
            else
            {
                userName=users.addUser(textBoxEmail.Text, Convert.ToInt32(comboBoxRole.SelectedValue), 0);
            }
            if (userName.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(userName);
            }
            else
            {
                string password = "";
                char delimiter = ':';
                string[] newphrase = userName.Split(delimiter);

                byte[] data = UTF8Encoding.UTF8.GetBytes("QUIROFANOSHRO"+newphrase[1]);
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

                users.makeUserPass(Convert.ToInt32(newphrase[1]), password);
                
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(textBoxEmail.Text);
                msg.Subject = "INFORMACIÓN DE USUARIO";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;

                msg.Body = "NOMBRE DE USUARIO: " + newphrase[0] + "\nCONTRASEÑA: QUIROFANOSHRO" + newphrase[1];
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
                    MessageBox.Show("Usuario creado correctamente, porfavor verificar correo ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al enviar");
                }
            }
            
        }
    }
}
