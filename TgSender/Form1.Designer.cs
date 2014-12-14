namespace TgSender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnLoadVideo = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnBlank = new System.Windows.Forms.ToolStripButton();
            this.BtnActiveSent = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelSent = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtReport = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtT10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtT9 = new System.Windows.Forms.TextBox();
            this.CmbTemplate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtT8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtT7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtT6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtT5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtT4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtT3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtT2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbEnding = new System.Windows.Forms.ComboBox();
            this.TxtTitle2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtT1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTitle1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblTime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sent = new System.Windows.Forms.DataGridViewImageColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axVLCPlugin21);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(440, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(6, 15);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(485, 242);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoadVideo,
            this.BtnDelete,
            this.BtnBlank,
            this.BtnActiveSent,
            this.BtnCancelSent,
            this.BtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(940, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnLoadVideo
            // 
            this.BtnLoadVideo.AutoSize = false;
            this.BtnLoadVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLoadVideo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnLoadVideo.Image = global::TgSender.Properties.Resources.movies;
            this.BtnLoadVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLoadVideo.Name = "BtnLoadVideo";
            this.BtnLoadVideo.Size = new System.Drawing.Size(32, 32);
            this.BtnLoadVideo.Text = "toolStripButton1";
            this.BtnLoadVideo.ToolTipText = "Import Video";
            this.BtnLoadVideo.Click += new System.EventHandler(this.BtnLoadVideo_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Image = global::TgSender.Properties.Resources.button_cancel;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(32, 32);
            this.BtnDelete.Text = "toolStripButton1";
            this.BtnDelete.ToolTipText = "Delete Selected Row";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnBlank
            // 
            this.BtnBlank.AutoSize = false;
            this.BtnBlank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBlank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBlank.Image = global::TgSender.Properties.Resources.empty;
            this.BtnBlank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBlank.Name = "BtnBlank";
            this.BtnBlank.Size = new System.Drawing.Size(32, 32);
            this.BtnBlank.Text = "toolStripButton1";
            this.BtnBlank.ToolTipText = "Empty From";
            this.BtnBlank.Click += new System.EventHandler(this.BtnBlank_Click);
            // 
            // BtnActiveSent
            // 
            this.BtnActiveSent.AutoSize = false;
            this.BtnActiveSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnActiveSent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnActiveSent.Image = global::TgSender.Properties.Resources.camera_test;
            this.BtnActiveSent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnActiveSent.Name = "BtnActiveSent";
            this.BtnActiveSent.Size = new System.Drawing.Size(32, 32);
            this.BtnActiveSent.Text = "toolStripButton1";
            this.BtnActiveSent.ToolTipText = "Add to Render Qeue";
            this.BtnActiveSent.Click += new System.EventHandler(this.BtnActiveSent_Click);
            // 
            // BtnCancelSent
            // 
            this.BtnCancelSent.AutoSize = false;
            this.BtnCancelSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancelSent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCancelSent.Image = global::TgSender.Properties.Resources.stop1normalred;
            this.BtnCancelSent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancelSent.Name = "BtnCancelSent";
            this.BtnCancelSent.Size = new System.Drawing.Size(32, 32);
            this.BtnCancelSent.Text = "toolStripButton1";
            this.BtnCancelSent.ToolTipText = "Cancel Render";
            this.BtnCancelSent.Click += new System.EventHandler(this.BtnCancelSent_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = false;
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRefresh.Image = global::TgSender.Properties.Resources.agt_reload;
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(32, 32);
            this.BtnRefresh.Text = "toolStripButton1";
            this.BtnRefresh.ToolTipText = "Refresh List";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title1,
            this.Title2,
            this.Duration,
            this.Insert,
            this.Order,
            this.Start,
            this.Done,
            this.Sent,
            this.IsDone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(919, 99);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.TxtReport);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.TxtT10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TxtT9);
            this.groupBox3.Controls.Add(this.CmbTemplate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TxtT8);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtT7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TxtT6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtT5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtT4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtT3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtT2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CmbEnding);
            this.groupBox3.Controls.Add(this.TxtTitle2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtT1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtTitle1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 321);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(312, 100);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 207);
            this.BtnSave.TabIndex = 62;
            this.BtnSave.Text = "INSERT";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtReport
            // 
            this.TxtReport.BackColor = System.Drawing.Color.MistyRose;
            this.TxtReport.Enabled = false;
            this.TxtReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtReport.Location = new System.Drawing.Point(58, 284);
            this.TxtReport.Multiline = true;
            this.TxtReport.Name = "TxtReport";
            this.TxtReport.Size = new System.Drawing.Size(248, 23);
            this.TxtReport.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(3, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Report:";
            // 
            // TxtT10
            // 
            this.TxtT10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT10.Location = new System.Drawing.Point(206, 252);
            this.TxtT10.Name = "TxtT10";
            this.TxtT10.Size = new System.Drawing.Size(100, 26);
            this.TxtT10.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(174, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "T10:";
            // 
            // TxtT9
            // 
            this.TxtT9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT9.Location = new System.Drawing.Point(58, 252);
            this.TxtT9.Name = "TxtT9";
            this.TxtT9.Size = new System.Drawing.Size(105, 26);
            this.TxtT9.TabIndex = 57;
            // 
            // CmbTemplate
            // 
            this.CmbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTemplate.FormattingEnabled = true;
            this.CmbTemplate.Items.AddRange(new object[] {
            "ComingSoon",
            "Beginning",
            "BroadCast"});
            this.CmbTemplate.Location = new System.Drawing.Point(58, 97);
            this.CmbTemplate.Name = "CmbTemplate";
            this.CmbTemplate.Size = new System.Drawing.Size(105, 21);
            this.CmbTemplate.TabIndex = 22;
            this.CmbTemplate.SelectedIndexChanged += new System.EventHandler(this.CmbTemplate_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(3, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Theme:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(9, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "T9:";
            // 
            // TxtT8
            // 
            this.TxtT8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT8.Location = new System.Drawing.Point(206, 220);
            this.TxtT8.Name = "TxtT8";
            this.TxtT8.Size = new System.Drawing.Size(100, 26);
            this.TxtT8.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(174, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "T8:";
            // 
            // TxtT7
            // 
            this.TxtT7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT7.Location = new System.Drawing.Point(58, 220);
            this.TxtT7.Name = "TxtT7";
            this.TxtT7.Size = new System.Drawing.Size(105, 26);
            this.TxtT7.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(9, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "T7:";
            // 
            // TxtT6
            // 
            this.TxtT6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT6.Location = new System.Drawing.Point(206, 188);
            this.TxtT6.Name = "TxtT6";
            this.TxtT6.Size = new System.Drawing.Size(100, 26);
            this.TxtT6.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(174, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "T6:";
            // 
            // TxtT5
            // 
            this.TxtT5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT5.Location = new System.Drawing.Point(58, 188);
            this.TxtT5.Name = "TxtT5";
            this.TxtT5.Size = new System.Drawing.Size(105, 26);
            this.TxtT5.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(9, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "T5:";
            // 
            // TxtT4
            // 
            this.TxtT4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT4.Location = new System.Drawing.Point(206, 156);
            this.TxtT4.Name = "TxtT4";
            this.TxtT4.Size = new System.Drawing.Size(100, 26);
            this.TxtT4.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(174, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "T4:";
            // 
            // TxtT3
            // 
            this.TxtT3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT3.Location = new System.Drawing.Point(58, 156);
            this.TxtT3.Name = "TxtT3";
            this.TxtT3.Size = new System.Drawing.Size(105, 26);
            this.TxtT3.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "T3:";
            // 
            // TxtT2
            // 
            this.TxtT2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT2.Location = new System.Drawing.Point(206, 124);
            this.TxtT2.Name = "TxtT2";
            this.TxtT2.Size = new System.Drawing.Size(100, 26);
            this.TxtT2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(174, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "T2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(170, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "End:";
            // 
            // CmbEnding
            // 
            this.CmbEnding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEnding.FormattingEnabled = true;
            this.CmbEnding.Items.AddRange(new object[] {
            "Program",
            "Documentary"});
            this.CmbEnding.Location = new System.Drawing.Point(206, 97);
            this.CmbEnding.Name = "CmbEnding";
            this.CmbEnding.Size = new System.Drawing.Size(100, 21);
            this.CmbEnding.TabIndex = 20;
            // 
            // TxtTitle2
            // 
            this.TxtTitle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTitle2.Location = new System.Drawing.Point(58, 58);
            this.TxtTitle2.Multiline = true;
            this.TxtTitle2.Name = "TxtTitle2";
            this.TxtTitle2.Size = new System.Drawing.Size(358, 33);
            this.TxtTitle2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(9, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Title2:";
            // 
            // TxtT1
            // 
            this.TxtT1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtT1.Location = new System.Drawing.Point(58, 124);
            this.TxtT1.Name = "TxtT1";
            this.TxtT1.Size = new System.Drawing.Size(105, 26);
            this.TxtT1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "T1:";
            // 
            // TxtTitle1
            // 
            this.TxtTitle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTitle1.Location = new System.Drawing.Point(58, 15);
            this.TxtTitle1.Multiline = true;
            this.TxtTitle1.Name = "TxtTitle1";
            this.TxtTitle1.Size = new System.Drawing.Size(358, 37);
            this.TxtTitle1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title1:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.LblTime.Location = new System.Drawing.Point(870, 165);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(61, 14);
            this.LblTime.TabIndex = 60;
            this.LblTime.Text = "HH:MM:SS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(479, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 9);
            this.label15.TabIndex = 61;
            this.label15.Text = "File:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TgSender.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Title1
            // 
            this.Title1.HeaderText = "Title1";
            this.Title1.Name = "Title1";
            this.Title1.ReadOnly = true;
            this.Title1.Width = 180;
            // 
            // Title2
            // 
            this.Title2.HeaderText = "Title2";
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            this.Title2.Visible = false;
            this.Title2.Width = 160;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 60;
            // 
            // Insert
            // 
            this.Insert.HeaderText = "Insert";
            this.Insert.Name = "Insert";
            this.Insert.ReadOnly = true;
            this.Insert.Width = 120;
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 120;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 120;
            // 
            // Done
            // 
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.Width = 120;
            // 
            // Sent
            // 
            this.Sent.HeaderText = "Sent";
            this.Sent.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Sent.Name = "Sent";
            this.Sent.ReadOnly = true;
            this.Sent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sent.Width = 50;
            // 
            // IsDone
            // 
            this.IsDone.HeaderText = "IsDone";
            this.IsDone.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IsDone.Name = "IsDone";
            this.IsDone.ReadOnly = true;
            this.IsDone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsDone.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 495);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T.G.  Sender V1.1 2014-03-11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtTitle1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtT1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbTemplate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbEnding;
        private System.Windows.Forms.TextBox TxtTitle2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripButton BtnLoadVideo;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.TextBox TxtT10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtT9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtT8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtT7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtT6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtT5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtT4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtT3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtT2;
        private System.Windows.Forms.ToolStripButton BtnBlank;
        private System.Windows.Forms.ToolStripButton BtnActiveSent;
        private System.Windows.Forms.TextBox TxtReport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ToolStripButton BtnCancelSent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.DataGridViewImageColumn Sent;
        private System.Windows.Forms.DataGridViewImageColumn IsDone;
    }
}

