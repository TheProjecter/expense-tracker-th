namespace Expense_Tracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnCloseGroupBox = new System.Windows.Forms.Button();
            this.lbYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.lbBaht3 = new System.Windows.Forms.Label();
            this.lbBaht2 = new System.Windows.Forms.Label();
            this.lbBaht1 = new System.Windows.Forms.Label();
            this.txtboxTotalBalance = new System.Windows.Forms.TextBox();
            this.txtboxTotalExpense = new System.Windows.Forms.TextBox();
            this.txtboxTotalIncome = new System.Windows.Forms.TextBox();
            this.lbTotalBalance = new System.Windows.Forms.Label();
            this.lbTotalExpense = new System.Windows.Forms.Label();
            this.lbTotalIncome = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripAddTransaction = new System.Windows.Forms.ToolStripButton();
            this.toolStripHeader = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBackToPresent = new System.Windows.Forms.ToolStripButton();
            this.toolStripViewHistory = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Snow;
            this.groupBox.Controls.Add(this.btnCloseGroupBox);
            this.groupBox.Controls.Add(this.lbYear);
            this.groupBox.Controls.Add(this.cmbYear);
            this.groupBox.Controls.Add(this.btnShowData);
            this.groupBox.Controls.Add(this.cmbMonth);
            this.groupBox.Controls.Add(this.lbMonth);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(884, 80);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "ข้อมูลย้อนหลัง";
            this.groupBox.Visible = false;
            // 
            // btnCloseGroupBox
            // 
            this.btnCloseGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseGroupBox.FlatAppearance.BorderSize = 0;
            this.btnCloseGroupBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseGroupBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseGroupBox.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseGroupBox.Image")));
            this.btnCloseGroupBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseGroupBox.Location = new System.Drawing.Point(830, 25);
            this.btnCloseGroupBox.Name = "btnCloseGroupBox";
            this.btnCloseGroupBox.Size = new System.Drawing.Size(42, 39);
            this.btnCloseGroupBox.TabIndex = 5;
            this.btnCloseGroupBox.UseVisualStyleBackColor = false;
            this.btnCloseGroupBox.Click += new System.EventHandler(this.btnCloseGroupBox_Click);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(12, 37);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(40, 19);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "พ.ศ.";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Enabled = false;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(58, 32);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(84, 27);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // btnShowData
            // 
            this.btnShowData.Enabled = false;
            this.btnShowData.Image = ((System.Drawing.Image)(resources.GetObject("btnShowData.Image")));
            this.btnShowData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowData.Location = new System.Drawing.Point(387, 32);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(124, 28);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.Text = "แสดงข้อมูล";
            this.btnShowData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Enabled = false;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(202, 32);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(179, 27);
            this.cmbMonth.TabIndex = 1;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(152, 35);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(44, 19);
            this.lbMonth.TabIndex = 0;
            this.lbMonth.Text = "เดือน";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(605, 443);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.TabStop = false;
            this.dataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_RowStateChanged);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Lavender;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.lbBaht3);
            this.panel.Controls.Add(this.lbBaht2);
            this.panel.Controls.Add(this.lbBaht1);
            this.panel.Controls.Add(this.txtboxTotalBalance);
            this.panel.Controls.Add(this.txtboxTotalExpense);
            this.panel.Controls.Add(this.txtboxTotalIncome);
            this.panel.Controls.Add(this.lbTotalBalance);
            this.panel.Controls.Add(this.lbTotalExpense);
            this.panel.Controls.Add(this.lbTotalIncome);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(605, 119);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(279, 443);
            this.panel.TabIndex = 2;
            // 
            // lbBaht3
            // 
            this.lbBaht3.AutoSize = true;
            this.lbBaht3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbBaht3.Location = new System.Drawing.Point(216, 221);
            this.lbBaht3.Name = "lbBaht3";
            this.lbBaht3.Size = new System.Drawing.Size(41, 19);
            this.lbBaht3.TabIndex = 9;
            this.lbBaht3.Text = "บาท";
            // 
            // lbBaht2
            // 
            this.lbBaht2.AutoSize = true;
            this.lbBaht2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbBaht2.Location = new System.Drawing.Point(216, 116);
            this.lbBaht2.Name = "lbBaht2";
            this.lbBaht2.Size = new System.Drawing.Size(41, 19);
            this.lbBaht2.TabIndex = 8;
            this.lbBaht2.Text = "บาท";
            // 
            // lbBaht1
            // 
            this.lbBaht1.AutoSize = true;
            this.lbBaht1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbBaht1.Location = new System.Drawing.Point(216, 44);
            this.lbBaht1.Name = "lbBaht1";
            this.lbBaht1.Size = new System.Drawing.Size(41, 19);
            this.lbBaht1.TabIndex = 7;
            this.lbBaht1.Text = "บาท";
            // 
            // txtboxTotalBalance
            // 
            this.txtboxTotalBalance.BackColor = System.Drawing.Color.White;
            this.txtboxTotalBalance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalBalance.Location = new System.Drawing.Point(21, 196);
            this.txtboxTotalBalance.Name = "txtboxTotalBalance";
            this.txtboxTotalBalance.ReadOnly = true;
            this.txtboxTotalBalance.Size = new System.Drawing.Size(189, 54);
            this.txtboxTotalBalance.TabIndex = 6;
            this.txtboxTotalBalance.TabStop = false;
            this.txtboxTotalBalance.Text = "0.00";
            this.txtboxTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtboxTotalExpense
            // 
            this.txtboxTotalExpense.BackColor = System.Drawing.Color.White;
            this.txtboxTotalExpense.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalExpense.ForeColor = System.Drawing.Color.Crimson;
            this.txtboxTotalExpense.Location = new System.Drawing.Point(21, 105);
            this.txtboxTotalExpense.Name = "txtboxTotalExpense";
            this.txtboxTotalExpense.ReadOnly = true;
            this.txtboxTotalExpense.Size = new System.Drawing.Size(189, 35);
            this.txtboxTotalExpense.TabIndex = 5;
            this.txtboxTotalExpense.TabStop = false;
            this.txtboxTotalExpense.Text = "0.00";
            this.txtboxTotalExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtboxTotalIncome
            // 
            this.txtboxTotalIncome.BackColor = System.Drawing.Color.White;
            this.txtboxTotalIncome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalIncome.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtboxTotalIncome.Location = new System.Drawing.Point(21, 33);
            this.txtboxTotalIncome.Name = "txtboxTotalIncome";
            this.txtboxTotalIncome.ReadOnly = true;
            this.txtboxTotalIncome.Size = new System.Drawing.Size(189, 35);
            this.txtboxTotalIncome.TabIndex = 4;
            this.txtboxTotalIncome.TabStop = false;
            this.txtboxTotalIncome.Text = "0.00";
            this.txtboxTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalBalance
            // 
            this.lbTotalBalance.AutoSize = true;
            this.lbTotalBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotalBalance.Location = new System.Drawing.Point(17, 174);
            this.lbTotalBalance.Name = "lbTotalBalance";
            this.lbTotalBalance.Size = new System.Drawing.Size(65, 19);
            this.lbTotalBalance.TabIndex = 3;
            this.lbTotalBalance.Text = "คงเหลือ";
            // 
            // lbTotalExpense
            // 
            this.lbTotalExpense.AutoSize = true;
            this.lbTotalExpense.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotalExpense.Location = new System.Drawing.Point(17, 83);
            this.lbTotalExpense.Name = "lbTotalExpense";
            this.lbTotalExpense.Size = new System.Drawing.Size(67, 19);
            this.lbTotalExpense.TabIndex = 2;
            this.lbTotalExpense.Text = "รายจ่าย";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalIncome.AutoSize = true;
            this.lbTotalIncome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotalIncome.Location = new System.Drawing.Point(17, 11);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(56, 19);
            this.lbTotalIncome.TabIndex = 1;
            this.lbTotalIncome.Text = "รายรับ";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddTransaction,
            this.toolStripHeader,
            this.toolStripLabel,
            this.toolStripBackToPresent,
            this.toolStripViewHistory});
            this.toolStrip.Location = new System.Drawing.Point(0, 80);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(884, 39);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripAddTransaction
            // 
            this.toolStripAddTransaction.ForeColor = System.Drawing.Color.Blue;
            this.toolStripAddTransaction.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddTransaction.Image")));
            this.toolStripAddTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddTransaction.Name = "toolStripAddTransaction";
            this.toolStripAddTransaction.Size = new System.Drawing.Size(123, 36);
            this.toolStripAddTransaction.Text = "เพิ่มรายการ";
            this.toolStripAddTransaction.Click += new System.EventHandler(this.toolStripAddTransaction_Click);
            // 
            // toolStripHeader
            // 
            this.toolStripHeader.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripHeader.Name = "toolStripHeader";
            this.toolStripHeader.Size = new System.Drawing.Size(249, 36);
            this.toolStripHeader.Text = "บัญชีรับ-จ่าย ประจำเดือน ... พ.ศ. ...";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel.Image")));
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(32, 36);
            this.toolStripLabel.Text = "toolStripLabel1";
            // 
            // toolStripBackToPresent
            // 
            this.toolStripBackToPresent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackToPresent.Image")));
            this.toolStripBackToPresent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackToPresent.Name = "toolStripBackToPresent";
            this.toolStripBackToPresent.Size = new System.Drawing.Size(175, 36);
            this.toolStripBackToPresent.Text = "กลับไปเดือนปัจจุบัน";
            this.toolStripBackToPresent.Visible = false;
            this.toolStripBackToPresent.Click += new System.EventHandler(this.toolStripBackToPresent_Click);
            // 
            // toolStripViewHistory
            // 
            this.toolStripViewHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripViewHistory.Image")));
            this.toolStripViewHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripViewHistory.Name = "toolStripViewHistory";
            this.toolStripViewHistory.Size = new System.Drawing.Size(153, 36);
            this.toolStripViewHistory.Text = "ดูข้อมูลย้อนหลัง";
            this.toolStripViewHistory.Click += new System.EventHandler(this.toolStripViewHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 130);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "วันที่";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "รายการ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "ประเภท";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 36;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,#0.00#";
            dataGridViewCellStyle5.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "จำนวนเงิน";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 110;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbBaht3;
        private System.Windows.Forms.Label lbBaht2;
        private System.Windows.Forms.Label lbBaht1;
        private System.Windows.Forms.TextBox txtboxTotalBalance;
        private System.Windows.Forms.TextBox txtboxTotalExpense;
        private System.Windows.Forms.TextBox txtboxTotalIncome;
        private System.Windows.Forms.Label lbTotalBalance;
        private System.Windows.Forms.Label lbTotalExpense;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripAddTransaction;
        private System.Windows.Forms.ToolStripLabel toolStripHeader;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolStripButton toolStripViewHistory;
        private System.Windows.Forms.ToolStripButton toolStripBackToPresent;
        private System.Windows.Forms.Button btnCloseGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

