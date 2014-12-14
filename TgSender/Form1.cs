using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaInfoNET;
using System.IO;

namespace TgSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            BAL.TGREQ Rq = new BAL.TGREQ();
            Rq.Title1 = TxtTitle1.Text.Trim();
            Rq.Title2 = TxtTitle2.Text.Trim();
            Rq.TEMPLATE = CmbTemplate.SelectedItem.ToString();
            Rq.ENDINGKIND = CmbEnding.SelectedItem.ToString();
            Rq.T1 = TxtT1.Text.Trim();
            Rq.T2 = TxtT2.Text.Trim();
            Rq.T3 = TxtT3.Text.Trim();
            Rq.T4 = TxtT4.Text.Trim();
            Rq.T5 = TxtT5.Text.Trim();
            Rq.T6 = TxtT6.Text.Trim();
            Rq.T7 = TxtT7.Text.Trim();
            Rq.T8 = TxtT8.Text.Trim();
            Rq.T9 = TxtT9.Text.Trim();
            Rq.T10 = TxtT10.Text.Trim();
            Rq.REPORT = TxtReport.Text.Trim();

            Rq.ISDONE = false;
            Rq.SENT = false;

            Rq.DATETIME_INSERT = dateTimePicker1.Value;
            Rq.DATETIME_DONE = dateTimePicker1.Value;
            Rq.DATETIME_ORDER = dateTimePicker1.Value;
            Rq.DATETIME_START = dateTimePicker1.Value;
            if (dataGridView1.SelectedRows.Count == 1)
            {

                BAL.TGREQ RqOrig = DAL.SelectById(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));

                Rq.ISDONE = RqOrig.ISDONE;
                Rq.SENT = RqOrig.SENT;

                Rq.DATETIME_INSERT = RqOrig.DATETIME_INSERT;
                Rq.DATETIME_DONE = RqOrig.DATETIME_DONE;
                Rq.DATETIME_ORDER = RqOrig.DATETIME_ORDER;
                Rq.DATETIME_START = RqOrig.DATETIME_START;
                Rq.VIDEODURTION = RqOrig.VIDEODURTION;
                if (RqOrig.DATETIME_START > RqOrig.DATETIME_ORDER && !RqOrig.ISDONE)
                {
                    MessageBox.Show("Selected row started for rendering,You have to wait", "Rendering", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Rq.Id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
                    DAL.Update(Rq);
                    MessageBox.Show("Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (axVLCPlugin21.playlist.items.count == 1)
                {
                    MediaFile VideoFile = new MediaFile(label15.Text);
                    Rq.VIDEODURTION = (VideoFile.Video[0].DurationMillis / 1000).ToString();

                    int InsertedId = DAL.Insert(Rq);
                    if (InsertedId > 0)
                    {
                        List<String> TempFiles = new List<String>();
                        TempFiles.Add(label15.Text.Trim());

                        string DstFileName = System.Configuration.ConfigurationSettings.AppSettings["DestDirectory"].Trim() + "\\" + InsertedId + System.IO.Path.GetExtension(label15.Text.Trim());
                        CopyFiles.CopyFiles Temp = new CopyFiles.CopyFiles(TempFiles, DstFileName);
                        Temp.EV_copyCanceled += Temp_EV_copyCanceled;
                        Temp.EV_copyComplete += Temp_EV_copyComplete;

                        CopyFiles.DIA_CopyFiles TempDiag = new CopyFiles.DIA_CopyFiles();
                        TempDiag.SynchronizationObject = this;
                        Temp.CopyAsync(TempDiag);


                       
                    }
                }
                else
                {
                    MessageBox.Show("You have to import video for this record", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BtnSave.Text = "INSERT";
            BtnSave.BackColor = Color.RoyalBlue;
            LoadGrid();



        }



        void Temp_EV_copyComplete()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                MessageBox.Show("Data Inserted", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

        }
        void Temp_EV_copyCanceled(List<CopyFiles.CopyFiles.ST_CopyFileDetails> filescopied)
        {
            //throw new NotImplementedException();
            MessageBox.Show("عملیات کپی متوقف شد");


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            LoadGrid();
        }
        protected void LoadGrid()
        {
            List<BAL.TGREQ> RqList = DAL.Select(dateTimePicker1.Value);
            dataGridView1.Rows.Clear();

            foreach (BAL.TGREQ item in RqList)
            {

                string Order = item.DATETIME_ORDER.ToString();
                if (item.DATETIME_ORDER == item.DATETIME_INSERT)
                {
                    Order = "---";
                }

                string Start = item.DATETIME_START.ToString();
                if (item.DATETIME_INSERT == item.DATETIME_START)
                {
                    Start = "---";
                }


                string Done = item.DATETIME_DONE.ToString();
                if (item.DATETIME_INSERT == item.DATETIME_DONE)
                {
                    Done = "---";
                }

                Bitmap Sent = TgSender.Properties.Resources.button_cancel;
                if (item.SENT)
                {
                    Sent = TgSender.Properties.Resources.camera_test;
                }

                Bitmap IsDoneimg = TgSender.Properties.Resources.button_cancel;
                if (item.ISDONE)
                {
                    IsDoneimg = TgSender.Properties.Resources.camera_test;
                }
                string Time = ConvertTime(double.Parse(item.VIDEODURTION));
                dataGridView1.Rows.Add(item.Id, item.Title1, item.Title2, Time, item.DATETIME_INSERT,
                    Order, Start, Done, Sent, IsDoneimg);
            }
            BtnBlank_Click(new object(), new EventArgs());

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
            CmbEnding.SelectedIndex = 0;
            CmbTemplate.SelectedIndex = 0;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                BAL.TGREQ Rq = DAL.SelectById(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));

                TxtTitle1.Text = Rq.Title1;
                TxtTitle2.Text = Rq.Title2;
                TxtReport.Text = Rq.REPORT;
                TxtT1.Text = Rq.T1;
                TxtT2.Text = Rq.T2;
                TxtT3.Text = Rq.T3;
                TxtT4.Text = Rq.T4;
                TxtT5.Text = Rq.T5;
                TxtT6.Text = Rq.T6;
                TxtT7.Text = Rq.T7;
                TxtT8.Text = Rq.T8;
                TxtT9.Text = Rq.T9;
                TxtT10.Text = Rq.T10;



                CmbEnding.SelectedIndex = CmbEnding.FindString(Rq.ENDINGKIND);
               
                CmbTemplate.SelectedIndex = CmbTemplate.FindString(Rq.TEMPLATE);
                CmbTemplate_SelectedIndexChanged(new object(), new EventArgs());

                if (Rq.ISDONE)
                {                   
                    if (System.IO.File.Exists(System.Configuration.ConfigurationSettings.AppSettings["FinalDirectory"].Trim() + "\\" + Rq.FinalFile))
                    {
                        label15.Text = System.Configuration.ConfigurationSettings.AppSettings["FinalDirectory"].Trim() + "\\" + Rq.FinalFile;
                        axVLCPlugin21.playlist.items.clear();
                        axVLCPlugin21.playlist.add("file:///" + System.Configuration.ConfigurationSettings.AppSettings["FinalDirectory"].Trim() + "\\" + Rq.FinalFile, "dfccdcdcd", null);
                        axVLCPlugin21.playlist.playItem(0);
                    }
                    else
                    {
                        axVLCPlugin21.playlist.items.clear();
                        axVLCPlugin21.playlist.stop();
                    }
                }
                else
                {
                    if (!Rq.SENT)
                    {
                        if (System.IO.File.Exists(System.Configuration.ConfigurationSettings.AppSettings["DestDirectory"].Trim() + "\\" + Rq.Id + ".mp4"))
                        {
                            label15.Text = System.Configuration.ConfigurationSettings.AppSettings["DestDirectory"].Trim() + "\\" + Rq.Id + ".mp4";
                            axVLCPlugin21.playlist.items.clear();
                            axVLCPlugin21.playlist.add("file:///" + System.Configuration.ConfigurationSettings.AppSettings["DestDirectory"].Trim() + "\\" + Rq.Id + ".mp4", "dfccdcdcd", null);
                            axVLCPlugin21.playlist.playItem(0);
                        }                        
                    }
                    else
                    {
                        axVLCPlugin21.playlist.items.clear();
                        axVLCPlugin21.playlist.stop();
                    }
                }



                BtnSave.BackColor = Color.OrangeRed;
                BtnSave.Text = "UPDATE";

            }

        }

        private void BtnBlank_Click(object sender, EventArgs e)
        {
            TxtReport.Text = "";
            TxtT1.Text = "";
            TxtT2.Text = "";
            TxtT3.Text = "";
            TxtT4.Text = "";
            TxtT5.Text = "";
            TxtT6.Text = "";
            TxtT7.Text = "";
            TxtT8.Text = "";
            TxtT9.Text = "";
            TxtT10.Text = "";
            TxtTitle1.Text = "";
            TxtTitle2.Text = "";
            dataGridView1.ClearSelection();
            BtnSave.Text = "INSERT";
            BtnSave.BackColor = Color.RoyalBlue;

            axVLCPlugin21.playlist.stop();
        }

        private void BtnActiveSent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                BAL.TGREQ Rq = DAL.SelectById(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                if (!Rq.SENT)
                {
                    DAL.UpdateSent(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()), true);
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Selected row is now in qeue", "Render", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnCancelSent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                BAL.TGREQ Rq = DAL.SelectById(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                if (!Rq.ISDONE && Rq.DATETIME_START <= Rq.DATETIME_ORDER)
                {
                    if (Rq.SENT)
                    {
                        DAL.UpdateSent(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()), false);
                        LoadGrid();
                    }
                    else
                    {
                        MessageBox.Show("Selected row is not in qeue", "Cancel Render", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Rq.ISDONE)
                    {
                        MessageBox.Show("Selected row's rendering finished", "Render", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Rq.DATETIME_START > Rq.DATETIME_ORDER)
                        {
                            MessageBox.Show("Selected row started for rendering", "Rendering", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult Res = MessageBox.Show("Are you sure to delete selected row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == System.Windows.Forms.DialogResult.Yes)
                {
                    BAL.TGREQ Rq = DAL.SelectById(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                    if (Rq.DATETIME_START > Rq.DATETIME_ORDER && !Rq.ISDONE)
                    {
                        MessageBox.Show("Selected row started for rendering,You have to wait", "Rendering", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            string DstFileName = System.Configuration.ConfigurationSettings.AppSettings["DestDirectory"].Trim() + "\\" + Rq.Id + ".mp4";
                            if (System.IO.File.Exists(DstFileName))
                            {
                                System.IO.File.Delete(DstFileName);
                            }
                        }
                        catch (Exception Exp)
                        {
                            MessageBox.Show(Exp.Message);
                        }
                        DAL.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                        LoadGrid();
                    }
                }
            }
        }

        private void BtnLoadVideo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label15.Text = openFileDialog1.FileName;
            axVLCPlugin21.playlist.items.clear();
            axVLCPlugin21.playlist.add("file:///" + openFileDialog1.FileName, "dfccdcdcd", null);
            axVLCPlugin21.playlist.playItem(0);
            // ConvertTime();

            MediaFile VideoFile = new MediaFile(openFileDialog1.FileName);
            LblTime.Text = ConvertTime(VideoFile.Video[0].DurationMillis/1000);
        }
        protected string ConvertTime(double InTime)
        {           
            TimeSpan t = TimeSpan.FromSeconds(InTime);
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds
                );
        }

        private void CmbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "/images/" + CmbTemplate.SelectedItem.ToString() + ".png");
        }
    }
}