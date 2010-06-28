namespace Expense_Tracker
{
    partial class AddTransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransactionForm));
            this.lbToday0 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbBaht = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbToday0
            // 
            this.lbToday0.AutoSize = true;
            this.lbToday0.Location = new System.Drawing.Point(18, 13);
            this.lbToday0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToday0.Name = "lbToday0";
            this.lbToday0.Size = new System.Drawing.Size(38, 19);
            this.lbToday0.TabIndex = 0;
            this.lbToday0.Text = "วันที่";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(18, 50);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(57, 19);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "รายการ";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(16, 90);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(59, 19);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "ประเภท";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(18, 132);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(77, 19);
            this.lbAmount.TabIndex = 4;
            this.lbAmount.Text = "จำนวนเงิน";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(204, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbBaht
            // 
            this.lbBaht.AutoSize = true;
            this.lbBaht.Location = new System.Drawing.Point(260, 132);
            this.lbBaht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBaht.Name = "lbBaht";
            this.lbBaht.Size = new System.Drawing.Size(38, 19);
            this.lbBaht.TabIndex = 6;
            this.lbBaht.Text = "บาท";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(324, 176);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtboxDescription.Location = new System.Drawing.Point(102, 47);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(334, 27);
            this.txtboxDescription.TabIndex = 0;
            this.txtboxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxDescription_KeyPress);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "รับ",
            "จ่าย"});
            this.cmbType.Location = new System.Drawing.Point(102, 87);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(151, 27);
            this.cmbType.TabIndex = 1;
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtboxAmount.Location = new System.Drawing.Point(102, 129);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(151, 27);
            this.txtboxAmount.TabIndex = 2;
            this.txtboxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtboxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAmount_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(102, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(171, 27);
            this.dateTimePicker.TabIndex = 7;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(448, 223);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtboxAmount);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbBaht);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbToday0);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTransactionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มรายการใหม่";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbToday0;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbBaht;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtboxDescription;
        public System.Windows.Forms.ComboBox cmbType;
        public System.Windows.Forms.TextBox txtboxAmount;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}