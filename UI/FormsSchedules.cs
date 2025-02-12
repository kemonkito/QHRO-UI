﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class FormsSchedules : Form
    {
        private ClassReports reports =new ClassReports();
        private Surgeries surgeries = new Surgeries();
        private ClassGetStrings stringsClass = new ClassGetStrings();
        private ClassOperatingRoom Operatigrooms = new ClassOperatingRoom();
        string pacientName = "";
        int formClosed;
        int surgerieId;
        int IdQ;
        string hour;
        string today;
        string dateSelected;
        public FormsSchedules()
        {
            InitializeComponent();
        }

        public void loadData(string date)
        {
            dataGridViewSchedule.DataSource = reports.dailySchedule(date);
            dataGridViewSchedule.Columns[0].Visible = false;
            dataGridViewSchedule.AutoResizeColumns();
            dataGridViewSchedule.AutoResizeRows();
            dataGridViewSchedule.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

        private void iconButtonDiffer_Click(object sender, EventArgs e)
        {
            FormDiffers fDiffers = new FormDiffers(surgerieId,pacientName);
            fDiffers.ShowDialog();
            loadData(today);
        }

        private void FormsSchedules_Load(object sender, EventArgs e)
        {
            dateTimeSurgeryDate.Value = DateTime.Now;
            today = DateTime.Now.ToString("yyyy/MM/dd");
            labelDate.Text = DateTime.Now.ToLongDateString();
            loadData(today);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string qx;
        string proc;
        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                surgerieId = Convert.ToInt32(dataGridViewSchedule.Rows[e.RowIndex].Cells[0].Value);
                pacientName = dataGridViewSchedule.Rows[e.RowIndex].Cells[4].Value.ToString();
                hour = dataGridViewSchedule.Rows[e.RowIndex].Cells[1].Value.ToString();

                qx = dataGridViewSchedule.Rows[e.RowIndex].Cells[2].Value.ToString();
                DataTable infoOperatingRooms = Operatigrooms.listoperatingRooms();
                foreach (DataRow OpRoom in infoOperatingRooms.Rows)
                {
                    string numQ = OpRoom.Field<string>(1).ToString();

                    if ((numQ == qx))
                    {
                        IdQ = OpRoom.Field<int>(0);
                    }
                }
                proc = dataGridViewSchedule.Rows[e.RowIndex].Cells[6].Value.ToString();

                iconButtonDiffer.Enabled = true;
                iconButtonReSchedule.Enabled = true;
                iconButtonFinish.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void iconButtonReSchedule_Click(object sender, EventArgs e)
        {
            FormReschedule formReschedule = new FormReschedule(surgerieId, pacientName, qx, hour, IdQ);
            formReschedule.ShowDialog();
            loadData(today);
        }

        private void iconButtonFinish_Click(object sender, EventArgs e)
        {

            string[] response;
            string hora = hour;
            string[] timeSep = stringsClass.getStrings(hora, new char[] { ':', ' ' });
            string h = timeSep[0];
            string m = timeSep[1];
            string AorP = timeSep[2];
            if (AorP == "A.M")
            {
                if (h == "12")
                {
                    h = "00";
                }
            }
            else if (AorP == "P.M")
            {
                h = ((Convert.ToInt32(h) % 12) + 12).ToString();
            }

            DateTime f1 = Convert.ToDateTime(h + ":" + m + ":00");
            string f2 = f1.ToString("HH:mm");
            string f3 = DateTime.Now.ToString("HH:mm");
            TimeSpan t1 = TimeSpan.Parse(f2);
            TimeSpan t2 = TimeSpan.Parse(f3);

            int i = TimeSpan.Compare(t1, t2);


            if (i > 0)
            {
                MessageBox.Show("No puedes finalizar una cirugía que aun no ha comenzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("¿Desea añadir datos postoperatorios?", "Finalizar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PostOperation p = new PostOperation(surgerieId, proc, hour);
                    p.ShowDialog();
                }

                MessageBox.Show(surgeries.finishSurgerie(surgerieId));
                DataTable infoOperatingRooms = Operatigrooms.listoperatingRooms();

                foreach (DataRow OpRoom in infoOperatingRooms.Rows)
                {
                    int IdQ = OpRoom.Field<int>(0);
                    string numQ = OpRoom.Field<string>(1).ToString();

                    if ((numQ == qx))
                    {
                        string resp = Operatigrooms.editoperatingRoom(numQ, "Mantenimiento", true, IdQ);

                    }
                }
                loadData(today);
            }

        }

        private void FormsSchedules_Activated(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dateSelected = dateTimeSurgeryDate.Value.ToString("yyyy/MM/dd");
            labelDate.Text = dateTimeSurgeryDate.Value.ToLongDateString();
            loadData(dateSelected);
        }
    }
}
