﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class Form1 : Form
    {
        int userId;
        int roleId;
        private ClassUsers users = new ClassUsers();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public bool Activate { get; set; }
        int initx = 4;
        int inity = 140;
        IconButton createButton(string name, string text)
        {
            
            IconButton btn = new IconButton();
            btn.Text = text;
            btn.Name = name;
            btn.Size=new Size(247, 45);
            btn.Location = new System.Drawing.Point(initx, inity+50);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Click += new EventHandler(this.buttonClick);
            inity = inity + 50;
            return btn;
        }

        void buttonClick(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            panelReportsMenu.Visible = false;
            statePanel = 0;
            if (btn.Name== "iconButtonDoctores")
            {
                openChildForm(new Doctors());
            }
            if (btn.Name == "iconButtonAnestesistas")
            {
                openChildForm(new Anesthetist());
            }
            if (btn.Name == "iconButtonPacientes")
            {
                openChildForm(new Patient());
            }
            if (btn.Name == "iconButtonAyudantes")
            {
                openChildForm(new Assistant());
            }
            if (btn.Name == "iconButtonQuirofanos")
            {
                openChildForm(new OperatingRooms());
            }
            if (btn.Name == "iconButtonServicios")
            {
                openChildForm(new Services());
            }
            if (btn.Name == "iconButtonSolicitar cirugía")
            {
                openChildForm(new RequestSurgery());
            }
            if (btn.Name == "iconButtonProgramar cirugía")
            {
                openChildForm(new assignSurgery());
            }
            if (btn.Name == "iconButtonUsuarios")
            {
                openChildForm(new Users());
            }
            if (btn.Name == "iconButtonPermisos")
            {
                openChildForm(new FormUserPermits());
            }
            if (btn.Name == "iconButtonBusquedas")
            {
                openChildForm(new FormSearch());
            }
            if (btn.Name == "iconButtonProgramaciones")
            {
                openChildForm(new FormsSchedules());
            }
        }
        public Form1(string userLog, int role, int serviceId, int idUser)
        {
            InitializeComponent();
            roleId = role;
            labelUserLog.Text = userLog;
            userId = idUser;
        }
        private Form activeForm = null;
        private void openChildForm(object formChild)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            Form fh = formChild as Form;
            activeForm = fh;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (roleId==1)
            {
                DataTable allPermits = users.GetPermits();
                iconButtonReports.Visible = true;
                iconButtonReports.Enabled = true;
                foreach (DataRow item in allPermits.Rows)
                {
                    if (item.Field<string>(2).ToString()!="Reportes")
                    {
                        panelSlideMenu.Controls.Add(createButton("iconButton" + item.Field<string>(2).ToString(), item.Field<string>(2).ToString()));
                    }
                
            
                }
            }
            else
            {
                DataTable userPermits = users.getPermitsByUserId(userId);
                if (userPermits.Rows.Count>0)
                {
                    foreach (DataRow item in userPermits.Rows)
                    {
                        DataTable infoPermit = users.GetPermitsById(Convert.ToInt32(item.Field<int>(1)));
                        foreach (DataRow itemPermit in infoPermit.Rows)
                        {
                            if (itemPermit.Field<string>(2).ToString() != "Reportes")
                            {
                                panelSlideMenu.Controls.Add(createButton("iconButton" + itemPermit.Field<string>(2).ToString(), itemPermit.Field<string>(2).ToString()));
                            }
                            else
                            {
                                iconButtonReports.Visible = true;
                                iconButtonReports.Enabled = true;
                            }
                        }
                        

                    }
                }
            }



            openChildForm(new FormMain());
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBoxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximized_Click(object sender, EventArgs e)
        {
            pictureBoxMaximized.Visible = false;
            pictureBoxNormal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxNormal_Click(object sender, EventArgs e)
        {
            pictureBoxMaximized.Visible = true;
            pictureBoxNormal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

       

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        int statePanel = 0;
        private void iconButtonReports_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = true;
            statePanel++;
            if (statePanel==2)
            {
                statePanel = 0;
                panelReportsMenu.Visible = false;
            }

        }

        private void iconButtonSurgerys_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormViewInterventions());
        }

      
        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormDailyReport());
        }

    

        private void iconButton5_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormViweOperatingRooms());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelReportsMenu.Visible = false;
            statePanel = 0;
            openChildForm(new FormProfile(labelUserLog.Text));
        }
    }
}
