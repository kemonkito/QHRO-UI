﻿
namespace UI
{
    partial class OperatingRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButtonList = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.dataGridViewOperatingRooms = new System.Windows.Forms.DataGridView();
            this.groupBoxoperatingroomData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.textBoxCurrentState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatingRooms)).BeginInit();
            this.groupBoxoperatingroomData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonList
            // 
            this.iconButtonList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonList.BackColor = System.Drawing.Color.White;
            this.iconButtonList.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonList.ForeColor = System.Drawing.Color.Black;
            this.iconButtonList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButtonList.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonList.IconSize = 30;
            this.iconButtonList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonList.Location = new System.Drawing.Point(488, 523);
            this.iconButtonList.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonList.Name = "iconButtonList";
            this.iconButtonList.Size = new System.Drawing.Size(228, 40);
            this.iconButtonList.TabIndex = 30;
            this.iconButtonList.Text = "Ver quirofanos";
            this.iconButtonList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonList.UseVisualStyleBackColor = false;
            this.iconButtonList.Visible = false;
            this.iconButtonList.Click += new System.EventHandler(this.iconButtonList_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSave.BackColor = System.Drawing.Color.White;
            this.iconButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButtonSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(2, 82);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(211, 38);
            this.iconButtonSave.TabIndex = 29;
            this.iconButtonSave.Text = "Guardar";
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // iconButtonUpdate
            // 
            this.iconButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonUpdate.BackColor = System.Drawing.Color.White;
            this.iconButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.iconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.iconButtonUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdate.IconSize = 30;
            this.iconButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUpdate.Location = new System.Drawing.Point(2, 162);
            this.iconButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Size = new System.Drawing.Size(211, 40);
            this.iconButtonUpdate.TabIndex = 28;
            this.iconButtonUpdate.Text = "Actualizar quirofano";
            this.iconButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdate.UseVisualStyleBackColor = false;
            this.iconButtonUpdate.Click += new System.EventHandler(this.iconButtonUpdate_Click);
            // 
            // iconButtonNew
            // 
            this.iconButtonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonNew.BackColor = System.Drawing.Color.White;
            this.iconButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonNew.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNew.ForeColor = System.Drawing.Color.Black;
            this.iconButtonNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonNew.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNew.IconSize = 30;
            this.iconButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNew.Location = new System.Drawing.Point(2, 2);
            this.iconButtonNew.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Size = new System.Drawing.Size(211, 40);
            this.iconButtonNew.TabIndex = 27;
            this.iconButtonNew.Text = "Agregar nuevo quirofano";
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = false;
            this.iconButtonNew.Click += new System.EventHandler(this.iconButtonNew_Click);
            // 
            // dataGridViewOperatingRooms
            // 
            this.dataGridViewOperatingRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOperatingRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOperatingRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOperatingRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperatingRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOperatingRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperatingRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOperatingRooms.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOperatingRooms.EnableHeadersVisualStyles = false;
            this.dataGridViewOperatingRooms.GridColor = System.Drawing.Color.White;
            this.dataGridViewOperatingRooms.Location = new System.Drawing.Point(2, 109);
            this.dataGridViewOperatingRooms.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOperatingRooms.Name = "dataGridViewOperatingRooms";
            this.dataGridViewOperatingRooms.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperatingRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOperatingRooms.RowHeadersVisible = false;
            this.dataGridViewOperatingRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dataGridViewOperatingRooms.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOperatingRooms.RowTemplate.Height = 24;
            this.dataGridViewOperatingRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOperatingRooms.Size = new System.Drawing.Size(445, 355);
            this.dataGridViewOperatingRooms.TabIndex = 31;
            this.dataGridViewOperatingRooms.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOperatingRooms_CellMouseClick);
            // 
            // groupBoxoperatingroomData
            // 
            this.groupBoxoperatingroomData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxoperatingroomData.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxoperatingroomData.Controls.Add(this.iconButtonList);
            this.groupBoxoperatingroomData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxoperatingroomData.Location = new System.Drawing.Point(452, 3);
            this.groupBoxoperatingroomData.Name = "groupBoxoperatingroomData";
            this.groupBoxoperatingroomData.Size = new System.Drawing.Size(721, 568);
            this.groupBoxoperatingroomData.TabIndex = 32;
            this.groupBoxoperatingroomData.TabStop = false;
            this.groupBoxoperatingroomData.Text = "Datos del quirofano";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.6129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.06452F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.711684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.34304F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboStatus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCurrentState, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelID, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 343);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.Location = new System.Drawing.Point(168, 26);
            this.textBoxNumber.MaxLength = 13;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(168, 26);
            this.textBoxNumber.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.labelNumber);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(18, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 32);
            this.panel1.TabIndex = 23;
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(13, 6);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(136, 20);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Nombre de quirofano";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(2, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "*";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(346, 29);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(51, 20);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "Estado";
            this.labelStatus.Visible = false;
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboStatus.Location = new System.Drawing.Point(402, 25);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(215, 28);
            this.comboStatus.TabIndex = 19;
            // 
            // textBoxCurrentState
            // 
            this.textBoxCurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentState.Location = new System.Drawing.Point(168, 93);
            this.textBoxCurrentState.MaxLength = 13;
            this.textBoxCurrentState.Name = "textBoxCurrentState";
            this.textBoxCurrentState.Size = new System.Drawing.Size(168, 26);
            this.textBoxCurrentState.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Estado actual";
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(597, 96);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 20);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.2653F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.7347F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxoperatingroomData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewOperatingRooms, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 162);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1176, 574);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.iconButtonNew, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconButtonSave, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.iconButtonUpdate, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(402, 136);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(215, 204);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // OperatingRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 947);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperatingRooms";
            this.Text = "OperatingRooms";
            this.Load += new System.EventHandler(this.OperatingRooms_Load);
            this.Resize += new System.EventHandler(this.OperatingRooms_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatingRooms)).EndInit();
            this.groupBoxoperatingroomData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonList;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonNew;
        private System.Windows.Forms.DataGridView dataGridViewOperatingRooms;
        private System.Windows.Forms.GroupBox groupBoxoperatingroomData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox textBoxCurrentState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}